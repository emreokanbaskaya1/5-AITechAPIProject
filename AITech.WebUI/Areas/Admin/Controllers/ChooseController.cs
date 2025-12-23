using AITech.WebUI.DTOs.ChooseDtos;
using AITech.WebUI.Services.ChooseServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChooseController : Controller
    {
        private readonly IChooseService _chooseService;

        public ChooseController(IChooseService chooseService)
        {
            _chooseService = chooseService;
        }

        public async Task<IActionResult> Index()
        {
            var chooses = await _chooseService.GetAllAsync();
            return View(chooses);
        }

        [HttpGet]
        public IActionResult CreateChoose()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateChoose(CreateChooseDto chooseDto)
        {
            if (ModelState.IsValid)
            {
                await _chooseService.CreateAsync(chooseDto);
                return RedirectToAction("Index");
            }
            return View(chooseDto);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateChoose(int id)
        {
            var choose = await _chooseService.GetByIdAsync(id);
            return View(choose);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateChoose(UpdateChooseDto chooseDto)
        {
            if (ModelState.IsValid)
            {
                await _chooseService.UpdateAsync(chooseDto);
                return RedirectToAction("Index");
            }
            return View(chooseDto);
        }

        public async Task<IActionResult> DeleteChoose(int id)
        {
            await _chooseService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
