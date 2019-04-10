using LegendOfFall.HelperClasses;
using LegendOfFall.Models;
using System.Web.Mvc;
using LegendOfFall.UnitOfWork;

namespace LegendOfFall.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AboutController : Controller
    {
        //AdminDataProvider DP = new AdminDataProvider();
        //AboutDataProvider aboutDataProvider = new AboutDataProvider();
        // GET: About
        IUnitOfWork _unitOfWork = new UnitOfWork.UnitOfWork();

        //public AboutController(IUnitOfWork unitOfWork)
        //{
        //    _unitOfWork = unitOfWork;
        //}


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Edit()
        {             
            return View(_unitOfWork.AboutRepository.GetAboutUs());
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(AboutU model)
        {
            _unitOfWork.AboutRepository.Edit(model);
            return RedirectToAction("About", "Admin");
        }
    }
}