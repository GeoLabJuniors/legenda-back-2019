using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LegendOfFall.Models;
using LegendOfFall.HelperClasses;

namespace LegendOfFall.Controllers
{
    public class AdminController : Controller
    {
        AdminDataProvider DP = new AdminDataProvider();
        
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Applicants()
        {
            return View(DP.GetApplicants());
        }

        public ActionResult About()
        {
            return View(DP.GetAboutUs());
        }

        public ActionResult Seasons()
        {
            return View(DP.GetSeasons());
        }

        public ActionResult Blogs()
        {
            return View(DP.GetBlogs());
        }        
    }
}