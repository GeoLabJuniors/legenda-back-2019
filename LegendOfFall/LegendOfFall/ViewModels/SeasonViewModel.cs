using LegendOfFall.CustomValidation;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace LegendOfFall.ViewModels
{
    public class SeasonViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="მიუთითეთ სათაური")]
        [Display(Name ="სეზონის სათაური")]
        public string Title { get; set; }

        [Display(Name = "ჩატარების წელი")]
        [Required(ErrorMessage = "მიუთითეთ წელი")]
        public string Year { get; set; }

        [Display(Name = "აღწერა")]
        [Required(ErrorMessage = "აღწერა სავალდებულოა")]
        public string Description { get; set; }

        [Display(Name ="ფოტო")]
        [ValidateUpload]
        public HttpPostedFileBase[] Upload { get; set; }

    }
}