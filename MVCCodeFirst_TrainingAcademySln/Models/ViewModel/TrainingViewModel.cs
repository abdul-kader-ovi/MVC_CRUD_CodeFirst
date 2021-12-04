using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCodeFirst_TrainingAcademySln.Models.ViewModel
{
    public class TrainingViewModel
    {
        [Key]
        [Display(Name = "Training Id")]
        public int TrainingId { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Training Name")]
        public string TrainingName { get; set; }
        [Required]
        [Display(Name = "Training Cost")]
        public decimal TrainingCost { get; set; }
    }
}