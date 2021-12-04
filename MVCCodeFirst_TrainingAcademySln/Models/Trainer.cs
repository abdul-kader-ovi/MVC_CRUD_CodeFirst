using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCodeFirst_TrainingAcademySln.Models
{
    public class Trainer
    {
        public Trainer()
        {
            this.Students = new HashSet<Student>();
        }
        [Key]
        public int TrainerId { get; set; }
        
        [StringLength(25, MinimumLength = 1)]
        public string TrainerName { get; set; }
        
        [StringLength(11, MinimumLength = 11)]
        public string PhoneNumber { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}