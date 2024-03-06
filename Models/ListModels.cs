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
        public string NumberNoti { get; set; }


        //thang
        public Cart cart{get; set;}
        public List<Cart> Carts { get; set; }
        public Post post{get; set;}
        public List<Post> Posts { get; set; }
    }
}