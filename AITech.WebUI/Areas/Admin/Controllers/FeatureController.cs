using AITech.WebUI.DTOs.FeatureDtos;
using AITech.WebUI.Services.FeatureServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FeatureController : Controller
    {
        private readonly IFeatureService _featureService;

        public FeatureController(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        public async Task<IActionResult> Index()
        {
            var features = await _featureService.GetAllAsync();
            return View(features);
        }

        [HttpGet]
        public IActionResult CreateFeature()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateFeature(CreateFeatureDto featureDto)
        {
            if (ModelState.IsValid)
            {
                await _featureService.CreateAsync(featureDto);
                return RedirectToAction("Index");
            }
            return View(featureDto);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateFeature(int id)
        {
            var feature = await _featureService.GetByIdAsync(id);
            return View(feature);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateFeature(UpdateFeatureDto featureDto)
        {
            if (ModelState.IsValid)
            {
                await _featureService.UpdateAsync(featureDto);
                return RedirectToAction("Index");
            }
            return View(featureDto);
        }

        public async Task<IActionResult> DeleteFeature(int id)
        {
            await _featureService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
