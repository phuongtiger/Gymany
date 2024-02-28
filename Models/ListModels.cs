using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymany.Models
{
    public class ListModels
    {
        public Product product{get; set;}
        public Customer customer {get; set;}
        public List<Product> Products { get; set; }
        public List<Notification> Notifications { get; set; }
    }
}