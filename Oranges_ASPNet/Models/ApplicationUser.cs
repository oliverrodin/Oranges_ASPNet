using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Oranges_ASPNet.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Full name")] public string FullName { get; set; } = string.Empty;
    }
}
