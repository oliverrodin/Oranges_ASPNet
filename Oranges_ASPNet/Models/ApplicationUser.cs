using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Oranges_ASPNet.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Full name")]
        public string FullName { get; set; } = string.Empty;


        public int? AddressId { get; set; }
        [ForeignKey("AddressId")]
        public Address? Address { get; set; }
    }
}
