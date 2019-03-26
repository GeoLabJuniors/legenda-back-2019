using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LegendOfFall.ViewModels
{
    public class ImageViewModel
    {
        public string Name { get; set; }
        public string Extension { get; set; }
        public string FullName => Name + Extension;
        
    }
}