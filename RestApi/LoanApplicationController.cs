using LoanApplication.Controllers;
using LoanApplication.Data;
using LoanApplication.DTO;
using LoanApplication.Models;
using LoanApplication.Views.PersonalLoan.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LoanApplication.RestApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanApplicationController : ControllerBase
    {
        private readonly LoanAppDbContext DbContext;

        public LoanApplicationController(LoanAppDbContext dbContext)
        {
            DbContext = dbContext;
        }

        [HttpPost("request-application")]
        public async Task<IActionResult> RequestApplication(ApplicationMessage message)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Customer customer = new Customer();
                    LoanInfo loan = new LoanInfo();

                    customer.Title = message.Title;
                    customer.Firstname = message.FirstName;
                    customer.Lastname = message.LastName;
                    customer.DateOfBirth = message.DateOfBirth;
                    customer.Mobile = message.Mobile;
                    customer.Email = message.Email;
                    customer.CreatedDate = DateTime.Now;
                    customer.UpdatedDate = DateTime.Now;

                    loan.Customer = customer;
                    loan.CustomerId = customer.Id;
                    loan.Term = message.Term;
                    loan.AmountRequired = message.AmountRequired;

                    DbContext.LoanInfos.Add(loan);
                    await DbContext.SaveChangesAsync();

                    return RedirectToAction("Create", "PersonalLoan", new { id = loan.CustomerId });
                }
            }
            catch (Exception ex)
            {

                throw;
            }

            return BadRequest("");
        }

        [HttpPost("calculate")]
        public async Task<IActionResult> CalculateAsync(ApplicationViewModel quot)
        {
            if (ModelState.IsValid)
            {
                string fee = DbContext.AppDatas.Where(x => x.Name == "EstablishmentFee").FirstOrDefault().Value;

                quot.EstablishmentFee = decimal.Parse(fee);

                ProductsController prodController = new ProductsController(this.DbContext);
                var productInfo = await prodController.GetProduct(quot.Product);
                double rate = 0;
                if (productInfo != null)
                {
                    var product = productInfo.Value;
                    int minimumDuration = 0;
                    int monthsNoInterest = 0;
                    if (product != null)
                    {
                        minimumDuration = product.MinimumDuration;
                        if (product.InterestRate != 0 && product.APRPeriod > 0)
                        {
                            //Effective interest rate = (r / 12) * (n - 2) / n
                            monthsNoInterest = product.APRPeriod;
                            double monthlyinterest = (double)product.InterestRate / 100;
                            int loanPeriod = quot.Term - monthsNoInterest;
                            rate = (double)(monthlyinterest / 12) * (loanPeriod / quot.Term);
                            quot.RepaymentAmount = (decimal)CalculatePmt(rate, quot.Term, (double)((quot.FinanceAmount + quot.EstablishmentFee)));
                        }
                        else if (product.NoInterestFree)
                        {
                            rate = (double)product.InterestRate / 100;
                            quot.RepaymentAmount = (decimal)CalculatePmt(rate, quot.Term, (double)((quot.FinanceAmount + quot.EstablishmentFee)));
                        }
                        else
                        {
                            quot.RepaymentAmount = (decimal)CalculatePmt(quot.FinanceAmount + quot.EstablishmentFee, quot.Term);
                        }
                    }
                }

                CustomerController custController = new CustomerController(this.DbContext);
                var Customer = await custController.GetCustomer(quot.CustomerId);

                ApplicationQuote app = new ApplicationQuote();
                app.CustomerId = quot.CustomerId;
                app.EstablishmentFee = quot.EstablishmentFee;
                app.RepaymentAmount = quot.RepaymentAmount;
                app.Term = quot.Term;
                app.Name = Customer.Value.Name();
                app.Mobile = Customer.Value.Mobile;
                app.Email = Customer.Value.Email;
                app.EstablishmentFee = quot.EstablishmentFee;
                app.Product = quot.Product;

                return Ok(app);
            }

            return BadRequest("Unable to calculate the loan.");
        }

        [HttpPost("create-application")]
        public async Task<IActionResult> Apply([FromBody] CreateApplicationMessage appDetail)
        {
            //Create Application
            try
            {
                Application newApp = new Application();
                newApp.EstablishmentFee = appDetail.EstablishmentFee;
                newApp.RepaymentAmount = appDetail.RepaymentAmount;
                newApp.FinanceAmount = appDetail.FinanceAmount;
                newApp.Term = appDetail.Term;
                newApp.CustomerId = appDetail.CustomerId;
                newApp.CreatedDate = DateTime.Now;
                newApp.UpdatedDate = DateTime.Now;
                newApp.ProductId = appDetail.ProductId;

                this.DbContext.Applications.Add(newApp);
                await this.DbContext.SaveChangesAsync();
                return Ok("Application created.");
            }
            catch (Exception ex)
            {

            }

            return BadRequest("Unable to save application");
        }

        private double CalculatePmt(double rate, double nper, double pv, double fv = 0, int type = 0)
        {
            double pmt = (rate * (pv / (1 - Math.Pow(1 + rate, -nper)))) + (fv / ((1 + rate * type) * (Math.Pow(1 + rate, nper) - 1)));

            return pmt;
        }

        //Compute pmt interest free
        private static decimal CalculatePmt(decimal loanAmount, int numberOfPeriods)
        {
            // Compute the PMT using the loan amount and number of periods
            decimal pmt = loanAmount / numberOfPeriods;

            return pmt;
        }
    }
}
