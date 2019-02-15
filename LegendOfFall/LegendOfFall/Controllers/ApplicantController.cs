using LegendOfFall.HelperClasses;
using LegendOfFall.ViewModels;
using System.Web.Mvc;

namespace LegendOfFall.Controllers
{
    [Authorize]
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
            var applicantToEdit = DP.GetApplicantById(id);
            var model = new ApplicantViewModel()
            {
                Id = applicantToEdit.Id,
                FirstName = applicantToEdit.FirstName,
                LastName = applicantToEdit.LastName,
                Bio = applicantToEdit.Bio,
                PhoneNumber = applicantToEdit.PhoneNumber                
            };
            return View(model);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(ApplicantViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            DP.Edit(model);
            return RedirectToAction("Applicants", "Admin");
        }
    }
}