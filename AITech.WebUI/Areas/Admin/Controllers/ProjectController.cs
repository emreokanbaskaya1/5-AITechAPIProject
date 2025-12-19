using AITech.WebUI.DTOs.ProjectDtos;
using AITech.WebUI.Services.CategoryServices;
using AITech.WebUI.Services.ProjectServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProjectController(IProjectService _projectService, ICategoryService _categoryService) : Controller
    {

        private async Task GetCategoriesAsync()
        {
            var categoryList = await _categoryService.GetAllAsync();
            ViewBag.categories = (from category in categoryList
                                  select new SelectListItem
                                  {
                                      Text = category.Name,
                                      Value = category.Id.ToString()
                                  }).ToList();

        }

        public async Task<IActionResult> Index()
        {
            var projects = await _projectService.GetAllAsync();
            return View(projects);
        }

        public async Task<IActionResult> CreateProject()
        {
            await GetCategoriesAsync();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProject(CreateProjectDto projectDto)
        {
            if (!ModelState.IsValid)
            {
                await GetCategoriesAsync();
                return View(projectDto);
            }


            await _projectService.CreateAsync(projectDto);
            return RedirectToAction("Index");
        }
    }
}
