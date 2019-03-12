using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LegendOfFall.Models;
using LegendOfFall.ViewModels;
using System.IO;
using System.Text;

namespace LegendOfFall.HelperClasses
{
    public class JudgeControllerDataProvider
    {
        LOFEntities1 _Context = new LOFEntities1();

        public Judge GetJudgeById(int id)
        {
            return _Context.Judges.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Judge> GetJudges()
        {
            return _Context.Judges;
        }
        
        public IEnumerable<Season> GetSeasons()
        {
            return _Context.Seasons.ToList();
        }

        public Photo GetPhotoByJudgeId(int id)
        {
            return _Context.Photos.FirstOrDefault(x => x.JudgeId == id);
        }

        public void Create(JudgeCreationViewModel model)
        {

            //adding judge itself
            if(model !=null)
            {
                var judgeToAdd = new Judge()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Bio = model.Bio,
                    Email = model.Email
                };


                _Context.Judges.Add(judgeToAdd);
                _Context.SaveChanges();



                //uploading image
                var file = model.Upload;
                var fileName = Guid.NewGuid().ToString();
                var extension = Path.GetExtension(file.FileName);
                var path = Path.Combine(HttpContext.Current.Server.MapPath("~/Content/assets/img"), fileName + extension);

                var photoToAdd = new Photo();
                photoToAdd.JudgeId = judgeToAdd.Id;
                photoToAdd.Name = fileName;
                photoToAdd.Extension = extension;
                photoToAdd.Path = path;

                file.SaveAs(path);
                _Context.Photos.Add(photoToAdd);
                _Context.SaveChanges();


                //adding season_judge
                foreach (var item in model.JudgedSeasonList)
                {
                    if(item.IsChecked)
                    {
                        var season_JudgeToAdd = new Season_Judge()
                        {
                            JudgeId = judgeToAdd.Id,
                            SeasonId = item.SeasonId
                        };

                        _Context.Season_Judge.Add(season_JudgeToAdd);
                        _Context.SaveChanges();
                    }                    
                }

            }
        }


        public void Edit(Judge model)
        {
            var judgeToEdit = GetJudgeById(model.Id);
            if(judgeToEdit != null)
            {
                judgeToEdit.FirstName = model.FirstName;
                judgeToEdit.LastName = model.LastName;
                judgeToEdit.Email = model.Email;
                judgeToEdit.Bio = model.Bio;

                _Context.SaveChanges();
            }
        }

        public void Delete(Judge model)
        {
            var judgeToDelete = _Context.Judges.FirstOrDefault(x => x.Id == model.Id);
            var season_JudgesToDelete = _Context.Season_Judge.Where(x => x.JudgeId == model.Id);

            if(judgeToDelete != null)
            {
                _Context.Season_Judge.RemoveRange(season_JudgesToDelete);
                _Context.Judges.Remove(judgeToDelete);

                _Context.SaveChanges();
            }

        }
    }
}