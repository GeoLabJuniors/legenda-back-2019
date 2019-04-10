using LegendOfFall.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LegendOfFall.Repositories
{
    public class SeasonRepository
    {
        LOFEntities1 _context;

        public SeasonRepository(LOFEntities1 context)
        {
            _context = context;
        }
    }
}