using System;
using System.ComponentModel.DataAnnotations;

namespace CS321_W2D2_StudentAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter a First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Enter a Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Enter a Date of Birth")]
        public DateTime BirthDate { get; set; }
        [Required(ErrorMessage = "Enter an Email Address")]
        [EmailAddress(ErrorMessage = "The Email Address is not valid")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter a Phone Number")]
        [Phone(ErrorMessage = "The Phone Number is not valid")]
        public string Phone { get; set; }
    }
}
