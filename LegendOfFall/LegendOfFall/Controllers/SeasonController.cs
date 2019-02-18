﻿using LegendOfFall.HelperClasses;
using LegendOfFall.Models;
using LegendOfFall.ViewModels;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LegendOfFall.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SeasonController : Controller
    {
        SeasonDataProvider DP = new SeasonDataProvider();
        // GET: Season


        public ActionResult Details(int id)
        {
            var viewModel = DP.GetSeasonById(id);
            ViewBag.Img = viewModel.Photos.FirstOrDefault(x => x.SeasonId == viewModel.Id);
            return View(viewModel);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(SeasonViewModel model, HttpPostedFileBase[] photo)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            DP.Create(model, photo);
            return RedirectToAction("Seasons", "Admin");
        }

        public ActionResult Edit(int id)
        {
            var seasonToEdit = DP.GetSeasonById(id);
            var viewModel = new SeasonViewModel()
            {
                Id = seasonToEdit.Id,
                Title = seasonToEdit.Title,
                Description = seasonToEdit.Description,
                Year = seasonToEdit.Year
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(SeasonViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            DP.Edit(model);
            return RedirectToAction("Seasons", "Admin");
        }

        public ActionResult Delete(int id)
        {
            return View(DP.GetSeasonById(id));
        }

        [HttpPost]
        public ActionResult Delete(Season model)
        {
            DP.Delete(model.Id);
            return RedirectToAction("Seasons", "Admin");
        }
    }
}