using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gymany.Models
{
    public class Member
    {
        [Key]
        public string MemberID { get; set; }

        public DateTime? Date { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [ForeignKey("Customer")]
        public string CustomerID { get; set; }
        public Customer Customer { get; set; }
    }
}