using System.ComponentModel.DataAnnotations;

namespace LoanApplication.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(150)]
        public string Description { get; set; }
        public decimal InterestRate { get; set; }
        //Annual Percentage Rate period
        public int APRPeriod { get; set; }
        public int MinimumDuration { get; set; }
        public bool NoInterestFree { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
