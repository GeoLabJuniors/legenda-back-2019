using LegendOfFall.Models;
using LegendOfFall.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace LegendOfFall.HelperClasses
{
    public class AdminDataProvider
    {        

        LOFEntities1 _db = new LOFEntities1();

        public AboutU GetAboutUs()
        {
            return _db.AboutUs.FirstOrDefault();            
        }

        public Contact GetContact()
        {
            return _db.Contacts.FirstOrDefault();
        }

        public void EditContacts(ContactViewModel model)
        {
            var toEdit = _db.Contacts.FirstOrDefault();
            toEdit.Address = model.Address;
            toEdit.Phone = model.Phone;
            toEdit.Phone2 = model.Phone2;
            toEdit.Email = model.Email;
            toEdit.Email2 = model.Email2;

            _db.SaveChanges();
        }

        public IEnumerable<Season> GetSeasons()
        {
            return _db.Seasons;
        }

        public IEnumerable<BlogPost> GetBlogs()
        {
            return _db.BlogPosts;
        }

        public IEnumerable<Applicant> GetApplicants()
        {
            return _db.Applicants;
        }

        public IEnumerable<Judge> GetJudges()
        {
            return _db.Judges;
        }
    }
}