using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoMVC.Models
{
    public class Validationcls
    {
        string firstName;
        string lastName;
        double salary;
        string pancard;
        string password;
        string confirmpassword;
        string phone;
        string Email;
        DateTime Doj;
        [Required(ErrorMessage ="Firstname is a must")]
        [StringLength(maximumLength:25,ErrorMessage ="Max Length is 25 only")]
        public string FirstName { get => firstName; set => firstName = value; }
        [Required(ErrorMessage ="Lastname is a must")]
        public string LastName { get => lastName; set => lastName = value; }
        [Required(ErrorMessage = "Salary is a must")]
        [Range(10000,200000,ErrorMessage ="salary must be between 10000 and 200000")]
        public double Salary { get => salary; set => salary = value; }
        [Required(ErrorMessage ="Is a must")]
        [RegularExpression("^[A-Z]{5}[0-9]{4}[A-Z]$",ErrorMessage ="is must")]
        public string Pancard { get => pancard; set => pancard = value; }
        [Required(ErrorMessage ="is a must")]
        public string Password { get => password; set => password = value; }
        [Required(ErrorMessage = "is a must")]
        [Compare("Password",ErrorMessage ="password mismatch")]
        [DataType(DataType.Password)]
        public string Confirmpassword { get => confirmpassword; set => confirmpassword = value; }
        [Phone(ErrorMessage ="enteer a valid phone num")]
        [MinLength(10,ErrorMessage ="10 digits only")]
        [MaxLength(10,ErrorMessage ="10 digits only")]
        public string Phone { get => phone; set => phone = value; }
        [EmailAddress(ErrorMessage ="enter valid email address")]
        public string Email1 { get => Email; set => Email = value; }
        //[Customage(ErrorMessage = "Age must be between 21 and 58")]
        [Customdoj(ErrorMessage ="Date cannot be greater than todays date")]
        
        public DateTime Doj1 { get => Doj; set => Doj = value; }
    }
}