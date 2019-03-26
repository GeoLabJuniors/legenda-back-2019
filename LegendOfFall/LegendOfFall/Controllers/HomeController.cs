using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LegendOfFall.Models;
using LegendOfFall.ViewModels;

namespace LegendOfFall.Controllers
{
    public class HomeController : Controller
    {
        LOFEntities1 _context = new LOFEntities1();

        public ActionResult Index()
        {
            var season = _context.Seasons.FirstOrDefault(x => x.Year == "2019");
            var judges = _context.Judges.OrderBy(x => Guid.NewGuid()).Take(6).ToList();
            var applicants = _context.Applicants.OrderBy(x => Guid.NewGuid()).Take(6).ToList();
            var applications = _context.Applications.OrderBy(x => Guid.NewGuid()).Take(3).ToList();
            var images = _context.Photos.ToList();

            HomePageViewModel model = new HomePageViewModel
            {
                Season = season,
                Judges = judges,
                Applicants = applicants,
                Applications = applications,
                CurrentSeasonPhotos = images.Where(x=>x.SeasonId == season.Id).ToList(),
                Images = images
            };


            return View(model);
        }
    }
}