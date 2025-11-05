using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="name is must")]
        // not null
        [StringLength(10,MinimumLength =3)]
        public string Name { get; set; }

        //for dropdown
        public Gender Gender{ get; set; }
        // for radio button
        public string MaritalStatus { get; set; }
        //for text area
        public string Address { get; set; }   // for TextArea

        // New Email property
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(18, 60, ErrorMessage = "Age must be between 18 and 60")]
        public int? Age { get; set; }  // nullable int is okay with Required
        [Required(ErrorMessage = "Phone number is required")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone number must be 10 digits")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{6,20}$",
    ErrorMessage = "Password must be 6-20 characters, include uppercase, lowercase, number, and special character")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }

    }

    //enum for dropdown
    public enum Gender
    {
        Male,Female

    }


}
