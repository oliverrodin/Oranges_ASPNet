using System.ComponentModel.DataAnnotations.Schema;

namespace Oranges_ASPNet.Models
{
    public class ProductStock
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        public Product Product { get; set; }
        [ForeignKey(nameof(ProductId))]
        public int ProductId { get; set; }
        
        
    }
}
