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

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public DateTime? Age { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        public decimal? Salary { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(200)]
        public string Image { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }
    }
}