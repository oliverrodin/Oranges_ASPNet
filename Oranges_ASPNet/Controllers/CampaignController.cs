using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Oranges_ASPNet.Data.Services.CampaignService;
using Oranges_ASPNet.Data.Services.ProductService;
using Oranges_ASPNet.Models.ViewModel;

namespace Oranges_ASPNet.Controllers
{

    [Authorize]
    public class CampaignController : Controller
    {
        private readonly ICampaignService _campaignService;
        private readonly IProductService _productService;

        public CampaignController(ICampaignService campaignService, IProductService productService)
        {
            _campaignService = campaignService;
            _productService = productService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }

        public async Task<IActionResult> List()
        {
            var campaigns = await _campaignService.GetAllCampaignsAsync();
            return View(campaigns);
        }

        public async Task<IActionResult> Create()
        {
            var products = await _productService.GetAllProductsAsync();
            ViewBag.Products = new SelectList(products, "Id", "Model");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewCampaignViewModel campaign)
        {
            if (!ModelState.IsValid)
            {
                var products = await _productService.GetAllProductsAsync();
                ViewBag.Products = new SelectList(products, "Id", "Model");
                return View(campaign);
            }
            await _campaignService.AddAsync(campaign.Id, campaign);

            return RedirectToAction("List");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var campaign = await _campaignService.GetCampaignByIdAsync(id);
            if (campaign == null)
                return View("NotFound");

            return View(campaign);

        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var campaign = await _campaignService.GetCampaignByIdAsync(id);
            if (campaign != null)
            {
                await _campaignService.DeleteAsync(id);
                return RedirectToAction("List");
            }
            return View("NotFound");

        }

    }
}
