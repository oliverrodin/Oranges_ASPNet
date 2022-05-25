using System.ComponentModel.DataAnnotations;

namespace Oranges_ASPNet.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Email")]
        [StringLength(100, ErrorMessage = "Email is required")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Name")]
        [StringLength(100, ErrorMessage = "Name is required")]
        public string UserId { get; set; }

        public List<OrderDetails> OrderDetails { get; set; }
       
    }
}
