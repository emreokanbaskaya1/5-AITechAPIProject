using AITech.WebUI.DTOs.AboutDtos;
using AITech.WebUI.Services.AboutServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        // GET: Admin/About/Index
        public async Task<IActionResult> Index()
        {
            var abouts = await _aboutService.GetAllAsync();
            return View(abouts);
        }

        // GET: Admin/About/CreateAbout
        [HttpGet]
        public IActionResult CreateAbout()
        {
            return View();
        }

        // POST: Admin/About/CreateAbout
        [HttpPost]
        public async Task<IActionResult> CreateAbout(CreateAboutDto aboutDto)
        {
            if (ModelState.IsValid)
            {
                await _aboutService.CreateAsync(aboutDto);
                return RedirectToAction("Index");
            }
            return View(aboutDto);
        }

        // GET: Admin/About/UpdateAbout/5
        [HttpGet]
        public async Task<IActionResult> UpdateAbout(int id)
        {
            var about = await _aboutService.GetByIdAsync(id);
            return View(about);
        }

        // POST: Admin/About/UpdateAbout
        [HttpPost]
        public async Task<IActionResult> UpdateAbout(UpdateAboutDto aboutDto)
        {
            if (ModelState.IsValid)
            {
                await _aboutService.UpdateAsync(aboutDto);
                return RedirectToAction("Index");
            }
            return View(aboutDto);
        }

        // GET: Admin/About/DeleteAbout/5
        public async Task<IActionResult> DeleteAbout(int id)
        {
            await _aboutService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
