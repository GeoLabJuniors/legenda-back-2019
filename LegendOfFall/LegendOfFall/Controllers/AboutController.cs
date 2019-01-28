using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LegendOfFall.Models;
using LegendOfFall.HelperClasses;

namespace LegendOfFall.Controllers
{
    public class AboutController : Controller
    {
        AdminDataProvider DP = new AdminDataProvider();
        AboutDataProvider aboutDataProvider = new AboutDataProvider();
        // GET: About
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Edit()
        {             
            return View(DP.GetAboutUs());
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(AboutU model)
        {
            aboutDataProvider.Edit(model);
            return RedirectToAction("About", "Admin");
        }
    }
}