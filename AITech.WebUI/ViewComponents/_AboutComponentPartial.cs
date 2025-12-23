using AITech.WebUI.Services.AboutItemServices;
using AITech.WebUI.Services.AboutServices;
using AITech.WebUI.Services.SocialServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        private readonly IAboutService _aboutService;
        private readonly IAboutItemService _aboutItemService;
        private readonly ISocialService _socialService;

        public _AboutComponentPartial(IAboutService aboutService, IAboutItemService aboutItemService, ISocialService socialService)
        {
            _aboutService = aboutService;
            _aboutItemService = aboutItemService;
            _socialService = socialService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var about = await _aboutService.GetAllAsync();
            var aboutItems = await _aboutItemService.GetAllAsync();
            var socials = await _socialService.GetAllAsync();

            ViewBag.AboutItems = aboutItems;
            ViewBag.Socials = socials;

            return View(about);
        }
    }
}
