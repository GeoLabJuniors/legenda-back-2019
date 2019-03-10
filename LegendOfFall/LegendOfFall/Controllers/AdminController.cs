using LegendOfFall.HelperClasses;
using LegendOfFall.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace LegendOfFall.Controllers
{
    [Authorize(Roles = "Admin")]
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
        
        public ActionResult Judges()
        {
            return View(DP.GetJudges());
        }

        public PartialViewResult BlogsByStatus(string status)
        {
            var blogsToReturn = new List<BlogPost>();
            switch(status)
            {
                case "approved":
                    blogsToReturn = DP.GetBlogs().Where(x => x.IsApproved == true).ToList();
                    break;
                case "waiting":
                    blogsToReturn = DP.GetBlogs().Where(x => x.IsApproved != true).ToList();
                    break;
                default:
                    blogsToReturn = DP.GetBlogs().ToList();
                    break;
            }

            return PartialView("_BlogPartial", blogsToReturn);
        }
    }
}