using LegendOfFall.HelperClasses;
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
    }
}