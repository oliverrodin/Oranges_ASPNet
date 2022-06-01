using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Oranges_ASPNet.Data.Enum;

namespace Oranges_ASPNet.Models
{
    public class Product
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

        
        public Brand Brand { get; set; }

        [Display(Name = "Select brand")]
        [Required(ErrorMessage = "brand is required")]
        [ForeignKey(nameof(BrandId))]
        public int BrandId { get; set; }

        
        public ProductStock Stock { get; set; }

        public int? ProductCampaignId { get; set; }
        [ForeignKey("ProductCampaignId")]
        public ProductCampaign? ProductCampaign { get; set; }






    }
}
