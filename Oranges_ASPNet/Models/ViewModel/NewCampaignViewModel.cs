using System.ComponentModel.DataAnnotations;

namespace Oranges_ASPNet.Models.ViewModel
{
    public class NewCampaignViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Display(Name = "Start date")]
        [Required(ErrorMessage = "Start date is required")]
        public DateTime StartDate { get; set; }

        [Display(Name = "End date")]
        [Required(ErrorMessage = "End date is required")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Discount in percentage (%)")]
        [Required(ErrorMessage = "Discount is required")]
        public int Discount { get; set; }

        [Display(Name = "Choose products")]
        [Required(ErrorMessage = "Choose products is required")]
        public List<int> ProductIds { get; set; }
    }
}
