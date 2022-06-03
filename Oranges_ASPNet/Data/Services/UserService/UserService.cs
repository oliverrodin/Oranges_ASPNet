using Microsoft.EntityFrameworkCore;
using Oranges_ASPNet.Data.Context;
using Oranges_ASPNet.Models;
using Oranges_ASPNet.Models.ViewModel;

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

        public async Task UpdateAsync(int id, UserViewModel user)
        {
            var item = await _context.Addresses.FirstOrDefaultAsync(x => x.AddressId == id);

            if (item != null)
            {
                item.Street = user.Street;
                item.State = user.State;
                item.City = user.City;
                item.Country = user.Country;
                item.FirstName = user.FirstName;
                item.LastName = user.LastName;
                item.Zip = user.Zip;
                item.AddressId = user.Id;
                await _context.SaveChangesAsync();
            }
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }


        public async Task<Address> GetAddressByIdAsync(int id) =>
          await _context.Addresses.FirstOrDefaultAsync(x => x.AddressId == id);

    }
}
