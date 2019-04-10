using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LegendOfFall.Models;

namespace LegendOfFall.Repositories
{
    public class AboutRepository
    {
        LOFEntities1 _context;

        public AboutRepository(LOFEntities1 context)
        {
            _context = context;
        }

        public AboutU GetAboutUs()
        {
            return _context.AboutUs.FirstOrDefault();
        }

        public void Edit(AboutU model)
        {
            var toEdit = _context.AboutUs.FirstOrDefault();

            if (toEdit != null)
            {
                toEdit.AboutUsDescription = model.AboutUsDescription;
                _context.SaveChanges();
            }                                    
        }
    }
}