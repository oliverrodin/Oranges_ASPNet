using System.ComponentModel.DataAnnotations.Schema;
using Oranges_ASPNet.Data.Enum;

namespace Oranges_ASPNet.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string ImgUrl { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public ProductCategory Category { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }


        public Brand Brand { get; set; }
        [ForeignKey(nameof(BrandId))]
        public int BrandId { get; set; }
        public ProductStock Stock { get; set; }
        
        



    }
}
