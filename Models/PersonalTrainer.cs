using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gymany.Models
{
    public class PersonalTrainer
    {
        [Key]
        public int PTID { get; set; }

        [Required(ErrorMessage = "Username is required.")]
        [StringLength(50, ErrorMessage = "Username length cannot exceed 50 characters.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(50, ErrorMessage = "Password length cannot exceed 50 characters.")]
        public string Password { get; set; }

         [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, ErrorMessage = "Name length cannot exceed 50 characters.")]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Age { get; set; }

        [StringLength(50, ErrorMessage = "Address length cannot exceed 50 characters.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Salary is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Salary must be greater than 0.")]
        public decimal? Salary { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [StringLength(50, ErrorMessage = "Email length cannot exceed 50 characters.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }
    }
}