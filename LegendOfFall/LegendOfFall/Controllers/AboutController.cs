using LegendOfFall.HelperClasses;
using LegendOfFall.Models;
using System.Web.Mvc;

namespace LegendOfFall.Controllers
{
    [Authorize(Roles = "Admin")]
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