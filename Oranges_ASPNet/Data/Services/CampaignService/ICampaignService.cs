using Oranges_ASPNet.Models;

namespace Oranges_ASPNet.Data.Services.CampaignService
{
    public interface ICampaignService
    {
        Task<List<ProductCampaign>> GetAllCampaignsAsync();
        Task<ProductCampaign> GetCampaignByIdAsync(int id);
        Task AddAsync(ProductCampaign campaign);
    }
}
