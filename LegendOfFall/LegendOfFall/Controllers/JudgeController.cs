﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LegendOfFall.HelperClasses;
using LegendOfFall.Models;
using LegendOfFall.ViewModels;
using System.Text;
using System.IO;

namespace LegendOfFall.Controllers
{
    [Authorize(Roles ="Admin")]
    public class JudgeController : Controller
    {
        JudgeControllerDataProvider DP = new JudgeControllerDataProvider();
        // GET: Judge
        public ActionResult Details(int id)
        {
            var image = DP.GetPhotoByJudgeId(id);
            string imageFullName = image.Name + image.Extension;
            
            ViewBag.ImagePath = Url.Content("~/Content/assets/img/" + imageFullName);
            return View(DP.GetJudgeById(id));
        }

        public ActionResult Create()
        {
            var seasons = DP.GetSeasons();
            var model = new JudgeCreationViewModel();
            model.JudgedSeasonList = new List<JudgedSeason>();

            foreach (Season item in seasons)
            {
                model.JudgedSeasonList.Add(new JudgedSeason() { IsChecked = false, SeasonId = item.Id, season = item });
            }                        

            return View(model);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(JudgeCreationViewModel model)
        {

            if (ModelState.IsValid)
            {
                DP.Create(model);
                return RedirectToAction("Judges", "Admin");
            }

            foreach(var item in model.JudgedSeasonList)
            {
                item.season = DP.GetSeasons().FirstOrDefault(x => x.Id == item.SeasonId);
            }

            return View(model);
        }



        public ActionResult Edit(int id)
        {
            var judge = DP.GetJudgeById(id);

            var model = new JudgeEditionViewModel()
            {
                FirstName = judge.FirstName,
                LastName = judge.LastName,
                Bio = judge.Bio,
                Email = judge.Email
            };
            
            return View(model);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(JudgeEditionViewModel model)
        {
            DP.Edit(model);

            return RedirectToAction("Judges","Admin");
        }



        public ActionResult Delete(int id)
        {
            var judgeToDelete = DP.GetJudgeById(id);
            return View(judgeToDelete);
        }


        [HttpPost]
        public ActionResult Delete(Judge model)
        {
            DP.Delete(model);

            return RedirectToAction("Judges", "Admin");
        }

    }
}