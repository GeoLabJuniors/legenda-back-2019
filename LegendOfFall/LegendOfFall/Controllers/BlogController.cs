using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LegendOfFall.Models;
using LegendOfFall.HelperClasses;

namespace LegendOfFall.Controllers
{
    public class BlogController : Controller
    {
        BlogDataProvider DP = new BlogDataProvider();
        // GET: Blog
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            return View(DP.GetBlogById(id));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(BlogPost model, HttpPostedFileBase[] photo)
        {
            DP.Create(model, photo);
            return View();
        }

        public ActionResult Edit(int id)
        {
            return View(DP.GetBlogById(id));
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(BlogPost model)
        {
            DP.Edit(model);
            return View();
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(BlogPost model)
        {
            return RedirectToAction("Blogs", "Admin");
        }
    }
}