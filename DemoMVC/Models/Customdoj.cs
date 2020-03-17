using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoMVC.Models
{
    public class Customdoj:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime D = Convert.ToDateTime(value);
            DateTime TD = DateTime.Now;
            int age=(int)(TD.Subtract(D).TotalDays/365);
            if (D > TD)
                return new ValidationResult("Date cannot be greater than todays date");
            else if (age < 21 || age > 58)
                return new ValidationResult("age must be between 21 to 58");
            else
                return ValidationResult.Success;

        }
    }
   
}