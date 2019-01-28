using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LegendOfFall.Models;
using LegendOfFall.HelperClasses;

namespace LegendOfFall.Controllers
{
    public class SeasonController : Controller
    {
        SeasonDataProvider DP = new SeasonDataProvider();
        // GET: Season
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(Season model, HttpPostedFileBase[] photo)
        {
            DP.Create(model, photo);
            return RedirectToAction("Seasons", "Admin");
        }

        public ActionResult Edit(int id)
        {
            return View(DP.GetSeasonById(id));
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(Season model)
        {
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