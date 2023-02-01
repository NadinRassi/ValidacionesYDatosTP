

using System;
using System.ComponentModel.DataAnnotations;

namespace WebApiControlStack.Validations
{
    public class PrecioMayorACeroAttribute:ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (0 > Convert.ToInt32(value))
            {
                return new ValidationResult("El precio tiene que ser mayor a cero");
            }

            return ValidationResult.Success;
        }
    }
}
