using System.ComponentModel.DataAnnotations;

namespace LegendOfFall.ViewModels
{
    public class BlogViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="მიუთითეთ ბლოგის სათაური")]
        [Display(Name = "ბლოგის სათაური")]
        public string Title { get; set; }

        [Required(ErrorMessage = "მიუთითეთ ბლოგის ტანი")]
        [Display(Name ="ბლოგის ტანი")]
        public string Body { get; set; }
    }
}