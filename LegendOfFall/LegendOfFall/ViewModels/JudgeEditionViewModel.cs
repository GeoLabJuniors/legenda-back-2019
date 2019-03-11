using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LegendOfFall.ViewModels
{
    public class JudgeEditionViewModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Bio { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}