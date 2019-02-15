using LegendOfFall.HelperClasses;
using LegendOfFall.ViewModels;
using System.Web.Mvc;

namespace LegendOfFall.Controllers
{
    [Authorize(Roles = "Admin")]
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
            var contactObject = DP.GetContact();
            var modelForView = new ContactViewModel()
            {
                Address = contactObject.Address,
                Phone = contactObject.Phone,
                Phone2 = contactObject.Phone2,
                Email = contactObject.Email,
                Email2 = contactObject.Email2
            };
            return View(modelForView);
        }

        [HttpPost]
        public ActionResult Edit(ContactViewModel model)
        {
            DP.EditContacts(model);
            return RedirectToAction("Index", "Contact");
        }
    }
}