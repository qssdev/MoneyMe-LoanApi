using System.ComponentModel.DataAnnotations;

namespace LoanApplication.Models
{
    public class BlackList
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Mobile/Email
        /// </summary>
        [MaxLength(50)]
        public string Type { get; set; }
        [MaxLength(50)]
        public string Value { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
