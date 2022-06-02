using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Oranges_ASPNet.Models
{
public class Brand
{
        [Key]
        public int Id { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Logo url")]
        [Required(ErrorMessage = "Logo url is required")]
        public string LogoUrl { get; set; } = string.Empty;

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country is required")]
        public string Country { get; set; } = string.Empty;

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; } = string.Empty;

        public IEnumerable<Product>? Products { get; set; }
    }
}
