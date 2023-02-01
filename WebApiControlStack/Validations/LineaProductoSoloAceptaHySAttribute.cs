
using System;
using System.ComponentModel.DataAnnotations;

namespace WebApiControlStack.Validations
{
    public class LineaProductoSoloAceptaHySAttribute:ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            
            if (Convert.ToString(value) != "H" && Convert.ToString(value) != "S")
            {
                return new ValidationResult("La linea de producto solo acepta H y S");
            }

            return ValidationResult.Success;
        }
    }
}
