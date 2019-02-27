using System.ComponentModel.DataAnnotations;
using System.Web;

namespace LegendOfFall.ViewModels
{
    public class BlogEditionViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "მიუთითეთ ბლოგის სათაური")]
        [Display(Name = "ბლოგის სათაური")]
        public string Title { get; set; }

        [Required(ErrorMessage = "მიუთითეთ ბლოგის ტანი")]
        [Display(Name = "ბლოგის ტანი")]
        public string Body { get; set; }

        [Display(Name = "აქვს აქტიური სტატუსი")]
        public bool IsApproved { get; set; }

        [Display(Name = "ფოტო")]        
        public HttpPostedFileBase[] Upload { get; set; }
    }
}