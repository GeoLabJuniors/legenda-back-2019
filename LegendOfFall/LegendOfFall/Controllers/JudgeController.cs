using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LegendOfFall.HelperClasses;
using LegendOfFall.Models;
using LegendOfFall.ViewModels;

namespace LegendOfFall.Controllers
{
    public class JudgeController : Controller
    {
        JudgeControllerDataProvider DP = new JudgeControllerDataProvider();
        // GET: Judge
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            var checkList = new List<JudgedSeason>();

            var seasons = DP.GetSeasons();            
            foreach(var season in seasons)
            {
                checkList.Add(new JudgedSeason() { IsChecked = false, Season = season });
            }

            var model = new JudgeCreationViewModel()
            {
                JudgedSeasonList = checkList
            };            

            return View(model);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(JudgeCreationViewModel model)
        {
            var checkList = new List<JudgedSeason>();

            var seasons = DP.GetSeasons();
            foreach (var season in seasons)
            {
                checkList.Add(new JudgedSeason() { IsChecked = false, Season = season });
            }

            model.JudgedSeasonList = checkList;

            DP.Create(model);
            return RedirectToAction("Index","Admin");
        }
    }
}