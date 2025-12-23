using AITech.WebUI.Services.FaqServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents
{
    public class _FaqComponentPartial : ViewComponent
    {
        private readonly IFaqService _faqService;

        public _FaqComponentPartial(IFaqService faqService)
        {
            _faqService = faqService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _faqService.GetAllAsync();
            return View(values);
        }
    }
}
