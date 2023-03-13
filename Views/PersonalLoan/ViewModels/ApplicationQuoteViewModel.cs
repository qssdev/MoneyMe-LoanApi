using LoanApplication.Models;
using System.ComponentModel.DataAnnotations;

namespace LoanApplication.Views.PersonalLoan.ViewModels
{
    public class ApplicationQuoteViewModel : Customer
    {
        [Display(Name = "Finance amount")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal FinanceAmount { get; set; }
        [Display(Name = "Repayments from")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Repayment { get; set; }
        [DisplayFormat(DataFormatString = "{0}")]
        public int Term { get; set; }
        public int CustomerAge { get; set; }
        public int Product { get; set; }
        public decimal EstablishmentFee { get; set; }
        public string Name { get; set; }
    }
}
