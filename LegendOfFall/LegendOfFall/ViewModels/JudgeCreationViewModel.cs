using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using LegendOfFall.Models;
using LegendOfFall.CustomValidation;

namespace LegendOfFall.ViewModels
{
    public class JudgeCreationViewModel
    {        
        [Required(ErrorMessage ="მიუთითეთ სახელი")]
        [Display(Name = "სახელი")]
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

        public List<JudgedSeason> JudgedSeasonList { get; set; }

        [ValidateSingleUpload]
        public HttpPostedFileBase Upload { get; set; }

    }

    public class JudgedSeason
    {
        public int SeasonId { get; set; }
        public bool IsChecked { get; set; }
        public Season season { get; set; }
    }
}