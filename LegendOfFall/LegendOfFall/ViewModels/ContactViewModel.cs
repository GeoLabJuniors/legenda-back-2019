using System.ComponentModel.DataAnnotations;

namespace LegendOfFall.ViewModels
{
    public class ContactViewModel
    {
        [Display(Name ="მისამართი")]
        public string Address { get; set; }

        [Display(Name = "ტელეფონი")]
        public string Phone { get; set; }

        [Display(Name = "ტელეფონი 2")]
        public string Phone2 { get; set; }

        [Display(Name = "ელფოსტა")]
        public string Email { get; set; }

        [Display(Name = "ელფოსტა 2")]
        public string Email2 { get; set; }        
    }
}