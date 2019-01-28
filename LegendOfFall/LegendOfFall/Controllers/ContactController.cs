using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LegendOfFall.Models;
using LegendOfFall.HelperClasses;

namespace LegendOfFall.Controllers
{
    public class ContactController : Controller
    {
        AdminDataProvider DP = new AdminDataProvider();
        // GET: Contact
        public ActionResult Index()
        {
            return View(DP.GetContact());
        }

        public ActionResult Edit()
        {
            return View(DP.GetContact());
        }

        [HttpPost]
        public ActionResult Edit(Contact model)
        {
            DP.EditContacts(model);
            return RedirectToAction("Index", "Contact");
        }
    }
}