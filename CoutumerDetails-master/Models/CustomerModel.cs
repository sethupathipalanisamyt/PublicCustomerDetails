using System.ComponentModel.DataAnnotations;

namespace CoustomerDetails.Models
{
    public class CustomerModel
    {
        [Key]
        public long CustomerID { get; set; }
        [Required]
        public string FullName { get; set; } = string.Empty;
        [Required]        
        public long PhoneNumber { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Country {  get; set; } = string.Empty;

        public string? Remark {  get; set; }
        [Required]
        public string? CoustomerType { get; set; }
        [Required]
        public DateTime DateOfBirth {  get; set; }
        [Required]
        public string Gender {  get; set; } = string.Empty;
        [Required]
        public string Isactive {  get; set; }=string.Empty;

    }
}
