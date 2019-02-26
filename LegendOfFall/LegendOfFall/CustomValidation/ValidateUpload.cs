using System.ComponentModel.DataAnnotations;
using System.Web;

namespace LegendOfFall.CustomValidation
{
    public class ValidateUpload : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var valueToValidate = (HttpPostedFileBase[])value;
            if (valueToValidate[0]==null)
            {
                return new ValidationResult("ატვირთეთ ფოტო");
            }

            return ValidationResult.Success;
        }
    }
}