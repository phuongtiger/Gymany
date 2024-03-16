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

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, ErrorMessage = "Name length cannot exceed 50 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Start date is required.")]
        public DateTime? StartDate { get; set; }

        [Required(ErrorMessage = "End date is required.")]
        public DateTime? EndDate { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Session is required.")]
        public string Session { get; set; }

        [Required(ErrorMessage = "Activity is required.")]
        public string Activity { get; set; }

        [ForeignKey("Member")]
        public int MemberID { get; set; }
        public Member Member { get; set; }

        [ForeignKey("PersonalTrainer")]
        public int PTID { get; set; }
        public PersonalTrainer PersonalTrainer { get; set; }
    }
}