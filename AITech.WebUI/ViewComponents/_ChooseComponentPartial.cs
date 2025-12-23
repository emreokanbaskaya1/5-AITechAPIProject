using AITech.WebUI.Services.ChooseServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents
{
    public class _ChooseComponentPartial : ViewComponent
    {
        private readonly IChooseService _chooseService;

        public _ChooseComponentPartial(IChooseService chooseService)
        {
            _chooseService = chooseService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _chooseService.GetAllAsync();
            return View(values);
        }
    }
}
