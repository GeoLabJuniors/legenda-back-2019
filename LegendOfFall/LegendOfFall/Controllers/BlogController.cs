using LegendOfFall.HelperClasses;
using LegendOfFall.Models;
using LegendOfFall.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace LegendOfFall.Controllers
{
    [Authorize]
    public class BlogController : Controller
    {
        BlogDataProvider DP = new BlogDataProvider();
        // GET: Blog
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles ="Admin")]
        public ActionResult Details(int id)
        {
            var blogModel = DP.GetBlogById(id);
            ViewBag.Img = blogModel.Photos.FirstOrDefault(x => x.BlogPostId == blogModel.Id);
            ViewBag.Imgs = blogModel.Photos;
            return View(blogModel);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(BlogViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            DP.Create(model, model.Upload);
            return RedirectToAction("Blogs", "Admin");
        }

        public ActionResult Edit(int id)
        {
            var blogToEdit = DP.GetBlogById(id);
            ViewBag.Imgs = blogToEdit.Photos;
            var modelForView = new BlogEditionViewModel()
            {
                Id = blogToEdit.Id,
                Title = blogToEdit.Title,
                Body = blogToEdit.Body,
                IsApproved = blogToEdit.IsApproved == null ? false : (bool)blogToEdit.IsApproved
                
            };
            return View(modelForView);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(BlogEditionViewModel model)
        {
            if(!ModelState.IsValid)
            {                
                var blogToEdit = DP.GetBlogById(model.Id);
                ViewBag.Imgs = blogToEdit.Photos;
                return View(model);
            }
            DP.Edit(model);
            return RedirectToAction("Blogs", "Admin");
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id)
        {
            var blogToDelete = DP.GetBlogById(id);

            return View(blogToDelete);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Delete(BlogPost model)
        {
            DP.DeleteBlog(model.Id);
            return RedirectToAction("Blogs", "Admin");
        }
    }
}