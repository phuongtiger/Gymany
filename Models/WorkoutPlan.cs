using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gymany.Models
{
    public class WorkoutPlan
    {
        [Key]
        public int WorkoutPlanID { get; set; }

        [StringLength(50, ErrorMessage = "Name length cannot exceed 50 characters.")]
        public string Name { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string Description { get; set; }

        public string Session { get; set; }

        public string Activity { get; set; }

        [ForeignKey("Member")]
        public int MemberID { get; set; }
        public Member Member { get; set; }

        [ForeignKey("PersonalTrainer")]
        public int PTID { get; set; }
        public PersonalTrainer PersonalTrainer { get; set; }
    }
}