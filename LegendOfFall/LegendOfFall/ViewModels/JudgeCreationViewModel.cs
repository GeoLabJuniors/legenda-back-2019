using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using LegendOfFall.Models;

namespace LegendOfFall.ViewModels
{
    public class JudgeCreationViewModel
    {        
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Bio { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public List<JudgedSeason> JudgedSeasonList { get; set; }

        public HttpPostedFileBase Upload { get; set; }

    }

    public class JudgedSeason
    {
        public Season Season { get; set; }
        public bool IsChecked { get; set; }
    }
}