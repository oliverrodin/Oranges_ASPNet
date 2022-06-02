using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Oranges_ASPNet.Data.Enum;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace Oranges_ASPNet.Models.ViewModel
{
    public class BrandViewModel
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Image")]
        [Required(ErrorMessage = "Image url is required")]
        public string LogoUrl { get; set; } = string.Empty;
        [Display(Name = "Brand name")]
        [Required(ErrorMessage = "Model name is required")]
        public string Name { get; set; } = string.Empty;
        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country is required")]
        public string Country { get; set; } = string.Empty;

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; } = string.Empty;

    }
}
