using AITech.WebUI.DTOs.AboutItemDtos;
using AITech.WebUI.Services.AboutItemServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutItemController : Controller
    {
        private readonly IAboutItemService _aboutItemService;

        public AboutItemController(IAboutItemService aboutItemService)
        {
            _aboutItemService = aboutItemService;
        }

        public async Task<IActionResult> Index()
        {
            var aboutItems = await _aboutItemService.GetAllAsync();
            return View(aboutItems);
        }

        [HttpGet]
        public IActionResult CreateAboutItem()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAboutItem(CreateAboutItemDto aboutItemDto)
        {
            if (ModelState.IsValid)
            {
                await _aboutItemService.CreateAsync(aboutItemDto);
                return RedirectToAction("Index");
            }
            return View(aboutItemDto);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateAboutItem(int id)
        {
            var aboutItem = await _aboutItemService.GetByIdAsync(id);
            return View(aboutItem);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAboutItem(UpdateAboutItemDto aboutItemDto)
        {
            if (ModelState.IsValid)
            {
                await _aboutItemService.UpdateAsync(aboutItemDto);
                return RedirectToAction("Index");
            }
            return View(aboutItemDto);
        }

        public async Task<IActionResult> DeleteAboutItem(int id)
        {
            await _aboutItemService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
