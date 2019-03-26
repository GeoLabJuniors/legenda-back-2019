using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LegendOfFall.Models;

namespace LegendOfFall.ViewModels
{
    public class HomePageViewModel
    {
        public Season Season { get; set; }
        public List<Judge> Judges { get; set; }
        public List<Applicant> Applicants { get; set; }
        public List<Application> Applications { get; set; }
        public List<Photo> CurrentSeasonPhotos { get; set; }
        public List<Photo> Images { get; set; }        
    }
}