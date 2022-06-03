using System.ComponentModel.DataAnnotations;

namespace Oranges_ASPNet.Models.ViewModel
{
    public class UserViewModel
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Firstname")]
        [Required(ErrorMessage = "Firstname is required")]
        public string FirstName { get; set; } = string.Empty;

        [Display(Name = "Lastname")]
        [Required(ErrorMessage = "Lastname is required")]
        public string LastName { get; set; } = string.Empty;

        [Display(Name = "Street")]
        [Required(ErrorMessage = "Street is required")]
        public string Street { get; set; } = string.Empty;

        [Display(Name = "City")]
        [Required(ErrorMessage = "City is required")]
        public string City { get; set; } = string.Empty;


        [Display(Name = "State")]
        [Required(ErrorMessage = "State is required")]
        public string State { get; set; } = string.Empty;


        [Display(Name = "Zip")]
        [Required(ErrorMessage = "Zip is required")]
        public string Zip { get; set; } = string.Empty;


        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country is required")]
        public string Country { get; set; } = string.Empty;


        //[Display(Name = "Telehone number")]
        //[Required(ErrorMessage = "Telephone number is required")]
        //public string TelephoneNumber { get; set; } = string.Empty;


    }
}
