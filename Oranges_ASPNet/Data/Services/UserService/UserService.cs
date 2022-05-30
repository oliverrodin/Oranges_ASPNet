using Microsoft.EntityFrameworkCore;
using Oranges_ASPNet.Data.Context;
using Oranges_ASPNet.Models;

namespace Oranges_ASPNet.Data.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _context;

        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<ApplicationUser>> GetAllUsersAsync() =>
            await _context.Users.Include(u => u.Address).ToListAsync();


        public async Task<ApplicationUser> GetUserByIdAsync(string id) =>
            await _context.Users.Include(u => u.Address).FirstOrDefaultAsync(u => u.Id == id);

        public Task AddAsync(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
