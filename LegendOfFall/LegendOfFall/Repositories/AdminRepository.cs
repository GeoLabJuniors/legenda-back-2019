using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LegendOfFall.Models;

namespace LegendOfFall.Repositories
{
    public class AdminRepository
    {
        LOFEntities1 _context;

        public AdminRepository(LOFEntities1 context)
        {
            _context = context;
        }
    }
}