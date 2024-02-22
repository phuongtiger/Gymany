using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gymany.Models
{
    public class Payment
    {
        [Key]
        public string PaymentID { get; set; }

        public DateTime? Date { get; set; }

        public int? Quantity { get; set; }

        [ForeignKey("Customer")]
        public string CustomerID { get; set; }
        public Customer Customer { get; set; }

        [ForeignKey("Product")]
        public string ProductID { get; set; }
        public Product Product { get; set; }
    }
}