using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LegendOfFall.Models;
using LegendOfFall.HelperClasses;

namespace LegendOfFall.Controllers
{
    public class ApplicantController : Controller
    {
        ApplicantDataProvider DP = new ApplicantDataProvider();
        // GET: Applicant
        public ActionResult Index(int id)
        {
            return View(DP.GetApplicantById(id));
        }

        public ActionResult Edit(int id)
        {
            return View(DP.GetApplicantById(id));
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(Applicant model)
        {
            DP.Edit(model);
            return RedirectToAction("Index", "Admin");
        }
    }
}