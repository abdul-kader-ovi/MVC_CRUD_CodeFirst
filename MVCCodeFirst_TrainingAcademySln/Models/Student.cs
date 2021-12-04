using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCodeFirst_TrainingAcademySln.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        
        public string StudentName { get; set; }
        
        public string Email { get; set; }
        
        public DateTime AdmissionDate { get; set; }
        public string ImageName { get; set; }
        public string ImageUrl { get; set; }
        
        public bool IsActive { get; set; }
        
        public int TrainingId { get; set; }
        
        public int TrainerId { get; set; }
        public virtual Training Training { get; set; }
        public virtual Trainer Trainer { get; set; }
    }
}