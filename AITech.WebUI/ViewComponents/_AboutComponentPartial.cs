using AITech.WebUI.Services.AboutServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        private readonly IAboutService _aboutService;

        public _AboutComponentPartial(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _aboutService.GetAllAsync();
            return View(values);
        }
    }
}
