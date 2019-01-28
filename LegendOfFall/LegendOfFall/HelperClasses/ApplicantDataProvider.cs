using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LegendOfFall.Models;

namespace LegendOfFall.HelperClasses
{
    public class ApplicantDataProvider
    {
        LOFEntities1 _db = new LOFEntities1();
        public Applicant GetApplicantById(int id)
        {
            return _db.Applicants.FirstOrDefault(x => x.Id == id);
        }

        public void Edit(Applicant model)
        {
            var applicantToEdit = _db.Applicants.FirstOrDefault(x => x.Id == model.Id);
            applicantToEdit.FirstName = model.FirstName;
            applicantToEdit.LastName = model.LastName;
            applicantToEdit.PhoneNumber = model.PhoneNumber;
            applicantToEdit.Bio = model.Bio;

            _db.SaveChanges();
        }
    }
}