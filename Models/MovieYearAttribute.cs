using System.ComponentModel.DataAnnotations;

namespace HW3.Models
{
    public class MovieYearAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is int year)
            {
                if (year > DateTime.Now.Year)
                {
                    return new ValidationResult("Рік випуску не може бути більшим за поточний");
                }
            }
            return ValidationResult.Success;
        }
    }
}
