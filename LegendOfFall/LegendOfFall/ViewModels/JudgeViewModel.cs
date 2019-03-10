using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LegendOfFall.ViewModels
{
    public class JudgeViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Bio { get; set; }
        public string Email { get; set; }
        public int[] Years { get; set; }
    }
}