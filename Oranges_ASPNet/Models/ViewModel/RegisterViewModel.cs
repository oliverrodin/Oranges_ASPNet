using System.ComponentModel.DataAnnotations;


namespace Oranges_ASPNet.Models.ViewModel
{
    public class RegisterViewModel
    {

        [Display(Name = "First name")]
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; } = string.Empty;

        [Display(Name = "Last name")]
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; } = string.Empty;

        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Email address is required")]
        public string EmailAddress { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone number is required")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Street is required")]
        public string Street { get; set; } = string.Empty;

        [Required(ErrorMessage = "City is required")]
        public string City { get; set; } = string.Empty;

        [Required(ErrorMessage = "State is required")]
        public string State { get; set; } = string.Empty;

        [Display(Name = "Zip Code")]
        [Required(ErrorMessage = "Zip Code is required")]
        public string Zip { get; set; } = string.Empty;

        [Required(ErrorMessage = "Country is required")]
        public string Country { get; set; } = string.Empty;

        [Required()]
        [StringLength(100, ErrorMessage = "The password must be between 6 - 100 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Confirm password is required")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }
    }
}
