using AITech.WebUI.DTOs.SocialDtos;
using AITech.WebUI.Services.SocialServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SocialController : Controller
    {
        private readonly ISocialService _socialService;

        public SocialController(ISocialService socialService)
        {
            _socialService = socialService;
        }

        public async Task<IActionResult> Index()
        {
            var socials = await _socialService.GetAllAsync();
            return View(socials);
        }

        [HttpGet]
        public IActionResult CreateSocial()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateSocial(CreateSocialDto socialDto)
        {
            if (ModelState.IsValid)
            {
                await _socialService.CreateAsync(socialDto);
                return RedirectToAction("Index");
            }
            return View(socialDto);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateSocial(int id)
        {
            var social = await _socialService.GetByIdAsync(id);
            return View(social);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateSocial(UpdateSocialDto socialDto)
        {
            if (ModelState.IsValid)
            {
                await _socialService.UpdateAsync(socialDto);
                return RedirectToAction("Index");
            }
            return View(socialDto);
        }

        public async Task<IActionResult> DeleteSocial(int id)
        {
            await _socialService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
