using Oranges_ASPNet.Models;

namespace Oranges_ASPNet.Data.Services.UserService
{
    public interface IUserService
    {
        Task<List<ApplicationUser>> GetAllUsersAsync();
        Task<ApplicationUser> GetUserByIdAsync(string id);
        Task AddAsync(ApplicationUser user);
        Task UpdateAsync(int id, ApplicationUser user);
        Task DeleteAsync(int id);
    }
}
