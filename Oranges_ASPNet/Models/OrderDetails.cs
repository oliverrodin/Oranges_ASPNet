using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oranges_ASPNet.Models
{
    public class OrderDetails
    {
        [Key]
        public int Id { get; set; }
        public int Amount { get; set; }

        public double Price { get; set; }


        public int ProductId { get; set; }
        [ForeignKey("Id")]
        public virtual Product Product { get; set; }

        
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }

    }
}
