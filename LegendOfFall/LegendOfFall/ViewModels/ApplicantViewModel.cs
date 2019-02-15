using System.ComponentModel.DataAnnotations;

namespace LegendOfFall.ViewModels
{
    public class ApplicantViewModel
    {
        public int Id { get; set; }

        [Display(Name = "სახელი")]
        [Required(ErrorMessage ="სახელი სავალდებულოა")]
        public string FirstName { get; set; }

        [Display(Name = "გვარი")]
        [Required(ErrorMessage = "გვარისავალდებულოა")]
        public string LastName { get; set; }

        [Display(Name ="ბიოგრაფია")]
        public string Bio { get; set; }

        [Display(Name = "ტელეფონის ნომერი")]
        [Required(ErrorMessage = "ნომერი სავალდებულოა")]
        public string PhoneNumber { get; set; }
    }
}