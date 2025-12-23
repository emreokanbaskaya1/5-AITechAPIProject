using AITech.WebUI.Services.BannerServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents
{
    public class _BannerComponentPartial : ViewComponent
    {
        private readonly IBannerService _bannerService;

        public _BannerComponentPartial(IBannerService bannerService)
        {
            _bannerService = bannerService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _bannerService.GetAllAsync();
            // Sadece aktif banner'larý al
            var activeBanners = values.Where(x => x.IsActive).ToList();
            return View(activeBanners);
        }
    }
}
