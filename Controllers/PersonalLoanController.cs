using LoanApplication.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using LoanApplication.Models;
using System.Text;
using LoanApplication.DTO;
using LoanApplication.Views.PersonalLoan.ViewModels;

namespace LoanApplication.Controllers
{

    public class PersonalLoanController : Controller
    {
        private readonly LoanAppDbContext DbContext;
        public PersonalLoanController(LoanAppDbContext dbContext)
        {
            DbContext = dbContext;
        }
        private readonly string baseUrl = "https://localhost:7055/api/";

        // GET: PersonalLoan/Create/5
        public async Task<IActionResult> Create(int? id)
        {
            DataLoader();
            var loanApp = new ApplicationMessage();
            if (id != null)
            {
                var loan = await DbContext.LoanInfos.Include(x => x.Customer).FirstOrDefaultAsync(x => x.CustomerId == id);
                loanApp = new ApplicationMessage
                {
                    Term = loan.Term,
                    AmountRequired = loan.AmountRequired,
                    Title = loan.Customer.Title,
                    FirstName = loan.Customer.Firstname,
                    LastName = loan.Customer.Lastname,
                    DateOfBirth = loan.Customer.DateOfBirth,
                    Mobile = loan.Customer.Mobile,
                    Email = loan.Customer.Email,
                    CustomerId = id.Value
                };

            }
            return View("Create", loanApp);
        }

        // GET: PersonalLoan/Create/5
        public async Task<IActionResult> Edit(int? id)
        {
            DataLoader();
            var loanApp = new ApplicationMessage();
            if (id != null)
            {
                var loan = await DbContext.LoanInfos.Include(x => x.Customer).FirstOrDefaultAsync(x => x.Id == id);
                loanApp = new ApplicationMessage
                {
                    Term = loan.Term,
                    AmountRequired = loan.AmountRequired,
                    Title = loan.Customer.Title,
                    FirstName = loan.Customer.Firstname,
                    LastName = loan.Customer.Lastname,
                    DateOfBirth = loan.Customer.DateOfBirth,
                    Mobile = loan.Customer.Mobile,
                    Email = loan.Customer.Email,
                    CustomerId = id.Value
                };

            }
            return View("Create", loanApp);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ApplicationMessage message)
        {
            ApplicationQuoteViewModel model = new ApplicationQuoteViewModel();
            if (!ModelState.IsValid)
            {
                if (message.ProductId <= 0)
                {
                    ModelState.AddModelError("", "Please select a product you want.");
                }
                DataLoader();
                return View("Create", message);
            }

            try
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.BaseAddress = new Uri(baseUrl);
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "LoanApplication/calculate");

                    ApplicationViewModel app = new ApplicationViewModel();
                    app.Term = message.Term;
                    app.FinanceAmount = message.AmountRequired;
                    app.CustomerId = message.CustomerId;
                    app.Product = message.ProductId;

                    StringContent content = new StringContent(JsonConvert.SerializeObject(app), Encoding.UTF8, "application/json");
                    request.Content = content;

                    HttpResponseMessage response = await httpClient.SendAsync(request);
                    string responseContent = await response.Content.ReadAsStringAsync();

                    ApplicationQuote appQuote = JsonConvert.DeserializeObject<ApplicationQuote>(responseContent);

                    model = new ApplicationQuoteViewModel()
                    {
                        Id = app.CustomerId,
                        Name = appQuote.Name,
                        Email = appQuote.Email,
                        Mobile = appQuote.Mobile,
                        Term = appQuote.Term,
                        FinanceAmount = message.AmountRequired,
                        Repayment = appQuote.RepaymentAmount,
                        Product = message.ProductId,
                        Firstname = message.FirstName,
                        Lastname = message.LastName,
                        Title = message.Title,
                        DateOfBirth = message.DateOfBirth,
                        EstablishmentFee = appQuote.EstablishmentFee
                    };
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return RedirectToAction("Apply", model);
        }

        public async Task<IActionResult> Apply(ApplicationQuoteViewModel application)
        {

            return View("Apply", application);
        }

        [HttpPost]
        public async Task<IActionResult> ApplyLoan(ApplicationQuoteViewModel application)
        {
            if (!ModelState.IsValid)
            {
                if (application.Product <= 0)
                {
                    ModelState.AddModelError("", "Please select a product you want.");
                }
                if (application.CustomerAge < 18)
                {
                    ModelState.AddModelError("", "Applicant must be 18 years old.");
                }
                var blackList = DbContext.BlackLists.Any(x => x.Value.Contains(application.Mobile) && x.Type == "Mobile");
                if (blackList)
                {
                    ModelState.AddModelError("", "This mobile number is blacklisted.");
                }
                string domain = application.Email.Split('@')[1];
                blackList = DbContext.BlackLists.Any(x => x.Type == "Email" && x.Value.Contains(domain));

                if (blackList)
                {
                    ModelState.AddModelError("", "The email address domain is blacklisted.");
                }
                return View("Apply", application);
            }

            CreateApplicationMessage newApp = new CreateApplicationMessage();
            
            using (var httpClient = new HttpClient())
            {
                newApp.Customer = new Customer();

                newApp.Customer.Firstname = application.Firstname;
                newApp.Customer.Lastname = application.Lastname;
                newApp.Customer.Mobile = application.Mobile;
                newApp.Customer.Email = application.Email;
                newApp.Customer.CreatedDate = DateTime.Now;
                newApp.Customer.DateOfBirth = application.DateOfBirth;
                newApp.Customer.Title = application.Title;
                newApp.Customer.Id = application.Id;

                newApp.CustomerId = application.Id;
                newApp.EstablishmentFee = application.EstablishmentFee;
                newApp.RepaymentAmount = application.Repayment;
                newApp.FinanceAmount = application.FinanceAmount;
                newApp.Term = application.Term;
                newApp.CreatedDate = DateTime.Now;
                newApp.UpdatedDate = DateTime.Now;
                newApp.ProductId = application.Product;

                httpClient.BaseAddress = new Uri(baseUrl);
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "LoanApplication/create-application");

                StringContent content = new StringContent(JsonConvert.SerializeObject(newApp), Encoding.UTF8, "application/json");
                request.Content = content;

                HttpResponseMessage response = await httpClient.SendAsync(request);
                string responseContent = await response.Content.ReadAsStringAsync();

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return RedirectToAction("Index", "Home");
                }

                return BadRequest("Unable to process the application.");
            }
        }

        public void DataLoader()
        {
            ViewBag.Titles = DbContext.AppDatas.Where(x => x.Name == "Title").Select(x => new
            {
                x.Id,
                x.Value
            }).ToList();
            ViewBag.Products = DbContext.Products.Select(x => new
            {
                x.Id,
                x.Name
            }).ToList();

        }
    }

}
