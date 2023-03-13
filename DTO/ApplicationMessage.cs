using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Text.Json.Serialization;

namespace LoanApplication.DTO
{
    public class ApplicationMessage
    {
        [JsonIgnore]
        [Display(Name = "Products")]
        public int ProductId { get; set; }
        public decimal AmountRequired { get; set; }
        public int Term { get; set; }
        public string Title { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public int CustomerId { get; set; }
    }
}
