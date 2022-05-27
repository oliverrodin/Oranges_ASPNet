using Microsoft.EntityFrameworkCore;
using Oranges_ASPNet.Data.Context;
using Oranges_ASPNet.Models;
using Oranges_ASPNet.Models.ViewModel;

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

        public async Task AddAsync(int id, NewCampaignViewModel campaign)
        {
            var products = new List<Product>();


            foreach (var item in campaign.ProductIds)
            {
                var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == item);
                products.Add(product);
            }
            var response = new ProductCampaign()
            {
                Id = id,
                Name = campaign.Name,
                Discount = campaign.Discount,
                StartDate = campaign.StartDate,
                EndDate = campaign.EndDate,
                Product = products
            };
            await _context.Campaigns.AddAsync(response);
            await _context.SaveChangesAsync();
        }
    }
}
