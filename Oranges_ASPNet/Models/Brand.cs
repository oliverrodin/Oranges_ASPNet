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

        public IEnumerable<Product> Products { get; set; }
    }
}
