using AITech.WebUI.DTOs.FaqDtos;
using AITech.WebUI.Services.FaqServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FaqController : Controller
    {
        private readonly IFaqService _faqService;

        public FaqController(IFaqService faqService)
        {
            _faqService = faqService;
        }

        public async Task<IActionResult> Index()
        {
            var faqs = await _faqService.GetAllAsync();
            return View(faqs);
        }

        [HttpGet]
        public IActionResult CreateFaq()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateFaq(CreateFaqDto faqDto)
        {
            if (ModelState.IsValid)
            {
                await _faqService.CreateAsync(faqDto);
                return RedirectToAction("Index");
            }
            return View(faqDto);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateFaq(int id)
        {
            var faq = await _faqService.GetByIdAsync(id);
            return View(faq);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateFaq(UpdateFaqDto faqDto)
        {
            if (ModelState.IsValid)
            {
                await _faqService.UpdateAsync(faqDto);
                return RedirectToAction("Index");
            }
            return View(faqDto);
        }

        public async Task<IActionResult> DeleteFaq(int id)
        {
            await _faqService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
