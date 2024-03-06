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
<<<<<<< HEAD
<<<<<<< HEAD
=======
        public Member member {get ; set ;}
        public List<WorkoutPlan> workoutPlans { get; set; }
        public bool CheckMember;
        public static implicit operator ListModels(Customer v)
        {
            throw new NotImplementedException();
        }
        public List<Member> members {get ; set ;}
>>>>>>> 4cc9f67f52084229977a45b5113b5ec7bb61abe2


        //thang
        public Cart cart{get; set;}
        public List<Cart> Carts { get; set; }
        public Post post{get; set;}
        public List<Post> Posts { get; set; }
<<<<<<< HEAD
=======
        public Member member {get ; set ;}
        public List<WorkoutPlan> workoutPlans { get; set; }
        public bool CheckMember;
        public static implicit operator ListModels(Customer v)
        {
            throw new NotImplementedException();
        }
>>>>>>> bebbc7c38c8041651d9e71ecb5120e5617201b89
=======
>>>>>>> 4cc9f67f52084229977a45b5113b5ec7bb61abe2
    }
}