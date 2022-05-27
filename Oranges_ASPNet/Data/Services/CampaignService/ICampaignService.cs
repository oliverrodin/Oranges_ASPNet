using Oranges_ASPNet.Models;
using Oranges_ASPNet.Models.ViewModel;

namespace Oranges_ASPNet.Data.Services.CampaignService
{
    public interface ICampaignService
    {
        Task<List<ProductCampaign>> GetAllCampaignsAsync();
        Task<ProductCampaign> GetCampaignByIdAsync(int id);
        Task AddAsync(int id, NewCampaignViewModel campaign);
    }
}
