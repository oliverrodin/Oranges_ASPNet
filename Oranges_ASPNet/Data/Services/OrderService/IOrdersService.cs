using Oranges_ASPNet.Models;

namespace Oranges_ASPNet.Data.Services
{
    public interface IOrdersService
    {
        Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAdress);
        Task<List<Order>> GetOrdersByUserIdAndRoleAsync(string userId, string userRole);
        Task<Order> GetOrderByIdAsync(int orderId);
    }
}
