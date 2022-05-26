using System.ComponentModel.DataAnnotations.Schema;

namespace Oranges_ASPNet.Models.ViewModel
{
    public class ProductStockViewModel
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public string ImgUrl { get; set; }
        public string Brand { get; set; }
        public string Product { get; set; }
        public int ProductId { get; set; }
    }
}
