using System.ComponentModel.DataAnnotations.Schema;

namespace Oranges_ASPNet.Models
{
    public class ProductCampaign
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int Discount { get; set; }
        
        public List<Product> Product { get; set; }

    }
}
