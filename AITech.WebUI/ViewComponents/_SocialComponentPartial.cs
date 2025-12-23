using AITech.WebUI.Services.SocialServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents
{
    public class _SocialComponentPartial : ViewComponent
    {
        private readonly ISocialService _socialService;

        public _SocialComponentPartial(ISocialService socialService)
        {
            _socialService = socialService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _socialService.GetAllAsync();
            return View(values);
        }
    }
}
