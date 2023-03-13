using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace LoanApplication.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(5)]
        public string Title { get; set; }
        [MaxLength(50)]
        public string Firstname { get; set; }
        [MaxLength(50)]
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        [MaxLength(20)]
        public string Mobile { get; set; }
        [MaxLength(50)]
        [EmailAddress]
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public string Name()
        { 
            return $"{Firstname} {Lastname}";
        }
    }
}
