using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LegendOfFall.ViewModels
{
    public class JudgeEditionViewModel
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required(ErrorMessage = "მიუთითეთ სახელი")]
        [Display(Name ="სახელი")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "მიუთითეთ გვარი")]
        [Display(Name = "გვარი")]
        public string LastName { get; set; }

        [Display(Name = "ბიოგრაფია")]
        public string Bio { get; set; }

        [Required(ErrorMessage = "მიუთითეთ ელფოსტა")]
        [EmailAddress]
        [Display(Name = "ელფოსტა")]
        public string Email { get; set; }
    }
}