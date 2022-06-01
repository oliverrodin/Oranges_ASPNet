using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Oranges_ASPNet.Data.Enum;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace Oranges_ASPNet.Models.ViewModel
{
    public class ProductViewModel
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Image")]
        [Required(ErrorMessage = "Image url is required")]
        public string ImgUrl { get; set; } = string.Empty;
        [Display(Name = "Model name")]
        [Required(ErrorMessage = "Model name is required")]
        public string Model { get; set; } = string.Empty;
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; } = string.Empty;
        [Display(Name = "Select category")]
        [Required(ErrorMessage = "Category is required")]
        public ProductCategory Category { get; set; }
        [Display(Name = "Price")]
        [Required(ErrorMessage = "Price is required")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Display(Name = "Stock quantity")]
        [Required(ErrorMessage = "Stock quantity is required")]
        public int Quantity { get; set; }

        [Display(Name = "Select brand")]
        [Required(ErrorMessage = "brand is required")]
        public int BrandId { get; set; }


    }
}
