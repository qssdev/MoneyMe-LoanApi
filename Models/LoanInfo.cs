using System.ComponentModel.DataAnnotations;

namespace LoanApplication.Models
{
    public class LoanInfo
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int Term { get; set; }
        public decimal AmountRequired { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public Customer Customer { get; set; }

    }
}
