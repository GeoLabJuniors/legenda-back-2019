using LegendOfFall.Models;
using LegendOfFall.ViewModels;
using System;
using System.IO;
using System.Linq;
using System.Web;

namespace LegendOfFall.HelperClasses
{
    public class SeasonDataProvider
    {        
        LOFEntities1 _db = new LOFEntities1();

        public Season GetSeasonById(int id)
        {
            return _db.Seasons.FirstOrDefault(x => x.Id == id);
        }

        public void Create(SeasonViewModel model, HttpPostedFileBase[] photos)
        {
            var seasonToAdd = new Season();
            seasonToAdd.Title = model.Title;
            seasonToAdd.Description = model.Description;
            seasonToAdd.Year = model.Year;
            seasonToAdd.DateCreated = DateTime.Now;

            _db.Seasons.Add(seasonToAdd);
            _db.SaveChanges();

            foreach (var file in photos)
            {
                var fileName = Guid.NewGuid().ToString();
                var extension = Path.GetExtension(file.FileName);
                var path = Path.Combine(HttpContext.Current.Server.MapPath("~/Content/assets/img"), fileName + extension);

                var photoToAdd = new Photo();
                photoToAdd.SeasonId = seasonToAdd.Id;
                photoToAdd.Name = fileName;
                photoToAdd.Extension = extension;
                photoToAdd.Path = path;

                file.SaveAs(path);
                _db.Photos.Add(photoToAdd);
                _db.SaveChanges();
            }
        }

        public void Edit(SeasonViewModel model)
        {
            var seasonToEdit = _db.Seasons.FirstOrDefault(x => x.Id == model.Id);

            seasonToEdit.Title = model.Title;
            seasonToEdit.Description = model.Description;
            seasonToEdit.Year = model.Year;

            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var seasonToDelete = _db.Seasons.FirstOrDefault(x => x.Id == id);
            var photosToDelete = _db.Photos.Where(x => x.SeasonId == id);
            var judgesToDelete = _db.Judges.Where(x => x.Season_Judge.Any(n => n.SeasonId == id));
            var applicantsToDelete = _db.Applicants.Where(x => x.Season_Applicant.Any(n => n.SeasonId == id));
            var appliationsToDelete = _db.Applications.Where(x => x.SeasonId == id);            

            _db.Applications.RemoveRange(appliationsToDelete);
            _db.Applicants.RemoveRange(applicantsToDelete);
            _db.Photos.RemoveRange(photosToDelete);
            _db.Judges.RemoveRange(judgesToDelete);
            _db.Season_Applicant.RemoveRange(_db.Season_Applicant.Where(x => x.SeasonId == id));
            _db.Winners.RemoveRange(_db.Winners.Where(x => x.SeasonId == id));
            _db.Season_Judge.RemoveRange(_db.Season_Judge.Where(x => x.SeasonId == id));
            _db.Seasons.Remove(seasonToDelete);

            _db.SaveChanges();
        }
    }
}