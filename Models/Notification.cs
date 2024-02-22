using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gymany.Models
{
    public class Notification
    {
        [Key]
        public string NotificationID { get; set; }

        public DateTime? Date { get; set; }

        public string Context { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [ForeignKey("Customer")]
        public string CustomerID { get; set; }
        public Customer Customer { get; set; }

        [ForeignKey("PersonalTrainer")]
        public string PTID { get; set; }
        public PersonalTrainer PersonalTrainer { get; set; }
    }
}