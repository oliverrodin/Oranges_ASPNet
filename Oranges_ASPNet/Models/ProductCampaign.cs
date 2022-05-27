using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oranges_ASPNet.Models
{
    public class ProductCampaign
    {
        public int Id { get; set; }
        [Display(Name = "Campaign")]
        public string Name { get; set; }
        [Display(Name = "Start date")]
        public DateTime StartDate { get; set; }
        [Display(Name = "End date")]
        public DateTime EndDate { get; set; }
        [Display(Name = "Discount (%)")]
        public int Discount { get; set; }
        public List<Product> Product { get; set; }


    }
}
