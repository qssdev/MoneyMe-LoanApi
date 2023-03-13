using System.ComponentModel;

namespace LoanApplication.Views.Home.ViewModels
{
    public class CustomerApplicationViewModel
    {
        public int Id { get; set; }
        [DisplayName("Name")]
        public string CustomerName  { get; set; }
        public int Term { get; set; }
        [DisplayName("Loan Amount")]
        public decimal LoanAmount { get; set; }
        public decimal Repayment { get; set; }
    }
}
