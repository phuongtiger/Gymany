using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace Gymany.Models
{
    public class ListModels
    {
        public Product product{get; set;}
        public Customer customer {get; set;}
        public List<Product> Products { get; set; }
        public IEnumerable<Product> ListProducts { get; set; }
        public List<Notification> Notifications { get; set; }
        public List<Category> Categories { get; set; }
        public string NumberNoti { get; set; }
  


        public Member member {get ; set ;}
        public List<WorkoutPlan> workoutPlans { get; set; }
        public bool CheckMember;
        public bool CheckPayment;
        public static implicit operator ListModels(Customer v)
        {
            throw new NotImplementedException();
        }
        public List<Member> members {get ; set ;}



        //thang
        public Cart cart{get; set;}
        public List<Cart> Carts { get; set; }
        public Post post{get; set;}
        public IEnumerable<Post> Posts { get; set; }
        public Order order { get; set; }
        public List<Order> orders { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        //public List<Post> Posts { get; set; }

    }
}