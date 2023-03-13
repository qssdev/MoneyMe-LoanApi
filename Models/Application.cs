using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace LoanApplication.Models
{
    public class Application
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Term { get; set; }
        public int CustomerId { get; set; }
        [Required]
        public decimal FinanceAmount { get; set; }
        [Required]
        public decimal RepaymentAmount { get; set; }
        public decimal EstablishmentFee { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}
