namespace Oranges_ASPNet.Models.ViewModel
{
    public class DashboardViewModel
    {
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<ApplicationUser> ApplicationUsers { get; set; }
        public IEnumerable<ProductStock> Stocks { get; set; }   
    }
}
