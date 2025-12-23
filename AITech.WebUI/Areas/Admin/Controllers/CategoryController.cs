using AITech.WebUI.DTOs.CategoryDtos;
using AITech.WebUI.Services.CategoryServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CategoryController(ICategoryService _categoryService) : Controller
    {
        
        public async Task<IActionResult> Index()
        {
            var categories = await _categoryService.GetAllAsync();
            return View(categories);
        }

        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto categoryDto)
        {
            if (ModelState.IsValid)
            {
                await _categoryService.CreateAsync(categoryDto);
                return RedirectToAction("Index");
            }
            return View(categoryDto);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateCategory(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto categoryDto)
        {
            if (ModelState.IsValid)
            {
                await _categoryService.UpdateAsync(categoryDto);
                return RedirectToAction("Index");
            }
            return View(categoryDto);
        }

        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _categoryService.DeleteAsync(id);
            return RedirectToAction("Index");
        }

    }
}
