using Microsoft.EntityFrameworkCore;
using Oranges_ASPNet.Data.Context;
using Oranges_ASPNet.Models;

namespace Oranges_ASPNet.Data.Services.CampaignService
{
    public class CampaignService : ICampaignService
    {
        private readonly AppDbContext _context;

        public CampaignService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<ProductCampaign>> GetAllCampaignsAsync()
        {
            return await _context.Campaigns.Include(c => c.Product).ToListAsync();
        }

        public async Task<ProductCampaign> GetCampaignByIdAsync(int id)
        {
            return await _context.Campaigns.Include(c => c.Product)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task AddAsync(ProductCampaign campaign)
        {
            await _context.Campaigns.AddAsync(campaign);
            await _context.SaveChangesAsync();
        }
    }
}
