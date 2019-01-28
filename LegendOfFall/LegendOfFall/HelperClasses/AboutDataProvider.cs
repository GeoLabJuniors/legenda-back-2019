using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LegendOfFall.Models;

namespace LegendOfFall.HelperClasses
{
    public class AboutDataProvider
    {
        LOFEntities1 _db = new LOFEntities1();

        public void Edit(AboutU model)
        {
            var toEdit = _db.AboutUs.FirstOrDefault();
            toEdit.AboutUsDescription = model.AboutUsDescription;

            _db.SaveChanges();
        }
    }
}