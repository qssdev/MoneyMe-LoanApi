namespace LoanApplication.Views.PersonalLoan.ViewModels
{
    public class ApplicationViewModel
    {
        public int Product { get; set; }
        public int Term { get; set; }
        public int CustomerId { get; set; }
        public decimal FinanceAmount { get; set; }
        public decimal RepaymentAmount { get; set; }
        public decimal EstablishmentFee { get; set; }
    }
}
