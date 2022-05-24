using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oranges_ASPNet.Models
{
    public class OrderDetails
    {
        [Key]
        public int OrderDetailsId { get; set; }
        public int Amount { get; set; }

        public decimal Price { get; set; }

        [ForeignKey("Id")]
        public int ProductId { get; set; }
        
        public virtual Product Product { get; set; }

        
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }

    }
}
