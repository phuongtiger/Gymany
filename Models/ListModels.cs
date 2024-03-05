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
        public List<Category> Categories { get; set; }
        public string NumberNoti { get; set; }
        public Member member {get ; set ;}
        public List<Member> members {get ; set ;}
         public List<WorkoutPlan> workoutPlans { get; set; }
    }
}