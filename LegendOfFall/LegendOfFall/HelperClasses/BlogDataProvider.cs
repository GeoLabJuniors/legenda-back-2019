using LegendOfFall.Models;
using LegendOfFall.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace LegendOfFall.HelperClasses
{
    public class BlogDataProvider
    {

        LOFEntities1 _db = new LOFEntities1();

        public IEnumerable<BlogPost> GetBlogs()
        {
            return _db.BlogPosts;
        }

        public BlogPost GetBlogById(int id)
        {
            return _db.BlogPosts.FirstOrDefault(x => x.Id == id);
        }

        public void Create(BlogViewModel model, HttpPostedFileBase[] photos)
        {
            var user = HttpContext.Current.User.Identity;
            var blogToAdd = new BlogPost();
            blogToAdd.Title = model.Title;
            blogToAdd.Body = model.Body;
            blogToAdd.DateCreated = DateTime.Now.Date;
            blogToAdd.ApplicantId = 1;
            blogToAdd.AuthorName = user.Name ;

            _db.BlogPosts.Add(blogToAdd);
            _db.SaveChanges();

            if(photos[0] != null)
            {
                foreach (var file in photos)
                {
                    var fileName = Guid.NewGuid().ToString();
                    var extension = Path.GetExtension(file.FileName);
                    var path = Path.Combine(HttpContext.Current.Server.MapPath("~/Content/assets/img"), fileName + extension);

                    var photoToAdd = new Photo();
                    photoToAdd.BlogPostId = blogToAdd.Id;
                    photoToAdd.Name = fileName;
                    photoToAdd.Extension = extension;
                    photoToAdd.Path = path;

                    file.SaveAs(path);
                    _db.Photos.Add(photoToAdd);
                    _db.SaveChanges();
                }
            }

        }

        public void Edit(BlogViewModel model, HttpPostedFileBase[] photos)
        {
            var blogToEdit = _db.BlogPosts.FirstOrDefault(x => x.Id == model.Id);

            if(blogToEdit != null)
            {
                blogToEdit.Title = model.Title;
                blogToEdit.Body = model.Body;
                blogToEdit.IsApproved = model.IsApproved;

                _db.SaveChanges();
            }
            

            if (photos[0] != null)
            {
                foreach (var file in photos)
                {
                    var fileName = Guid.NewGuid().ToString();
                    var extension = Path.GetExtension(file.FileName);
                    var path = Path.Combine(HttpContext.Current.Server.MapPath("~/Content/assets/img"), fileName + extension);

                    var photoToAdd = new Photo();
                    photoToAdd.BlogPostId = blogToEdit.Id;
                    photoToAdd.Name = fileName;
                    photoToAdd.Extension = extension;
                    photoToAdd.Path = path;

                    file.SaveAs(path);
                    _db.Photos.Add(photoToAdd);
                    _db.SaveChanges();
                }
            }
        }

        public void DeleteBlog(int id)
        {
            var blogToDelete = _db.BlogPosts.FirstOrDefault(x => x.Id == id);
            var photosToDelete = _db.Photos.Where(x => x.BlogPostId == id);

            _db.Photos.RemoveRange(photosToDelete);
            _db.BlogPosts.Remove(blogToDelete);
            _db.SaveChanges();
        }
    }
}