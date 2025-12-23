using AITech.WebUI.Services.ProjectServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents
{
    public class _ProjectComponentPartial : ViewComponent
    {
        private readonly IProjectService _projectService;

        public _ProjectComponentPartial(IProjectService projectService)
        {
            _projectService = projectService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _projectService.GetAllAsync();
            return View(values);
        }
    }
}
