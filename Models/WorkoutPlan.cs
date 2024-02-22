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
        public string WorkoutPlanID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string Description { get; set; }

        public string Session { get; set; }

        public string Activity { get; set; }

        [ForeignKey("Member")]
        public string MemberID { get; set; }
        public Member Member { get; set; }

        [ForeignKey("PersonalTrainer")]
        public string PTID { get; set; }
        public PersonalTrainer PersonalTrainer { get; set; }
    }
}