using LoanApplication.Models;

public class CreateApplicationMessage
{
    public int Id { get; set; }
    public int Term { get; set; }
    public int CustomerId { get; set; }
    public decimal FinanceAmount { get; set; }
    public decimal RepaymentAmount { get; set; }
    public decimal EstablishmentFee { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public int ProductId { get; set; }
    public Customer Customer { get; set; }
}