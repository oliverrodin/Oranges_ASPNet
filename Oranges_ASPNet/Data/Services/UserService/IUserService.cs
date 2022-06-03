using Oranges_ASPNet.Models;
using Oranges_ASPNet.Models.ViewModel;

namespace Oranges_ASPNet.Data.Services.UserService
{
    public interface IUserService
    {
        Task<List<ApplicationUser>> GetAllUsersAsync();
        Task<ApplicationUser> GetUserByIdAsync(string id);
        Task AddAsync(ApplicationUser user);
        Task UpdateAsync(int id, UserViewModel user);
        Task DeleteAsync(int id);

        Task<Address> GetAddressByIdAsync(int id);
    }
}
