using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCodeFirst_TrainingAcademySln.Models.ViewModel
{
    public class TrainerViewModel
    {
        [Key]
        [Display(Name = "Trainer Id")]
        public int TrainerId { get; set; }
        [DataType(DataType.Text)]
        [Required]
        [Display(Name = "Trainer Name")]
        public string TrainerName { get; set; }
        [Required]
        [Display(Name = "Phone")]
        public string PhoneNumber { get; set; }
    }
}