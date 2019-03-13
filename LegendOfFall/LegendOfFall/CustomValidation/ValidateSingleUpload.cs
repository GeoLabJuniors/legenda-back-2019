using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LegendOfFall.CustomValidation
{
    public class ValidateSingleUpload : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var valueToValidate = (HttpPostedFileBase)value;

            if(valueToValidate == null)
            {
                return new ValidationResult("ატვირთეთ ფოტო");
            }

            return ValidationResult.Success;
        }
    }
}