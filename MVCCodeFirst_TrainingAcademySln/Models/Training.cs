using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCodeFirst_TrainingAcademySln.Models
{
    public class Training
    {
        public Training()
        {
            this.Students = new HashSet<Student>();
        }
        [Key]
        public int TrainingId { get; set; }
        
        [StringLength(25, MinimumLength = 1)]
        public string TrainingName { get; set; }
        
        public decimal TrainingCost { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}