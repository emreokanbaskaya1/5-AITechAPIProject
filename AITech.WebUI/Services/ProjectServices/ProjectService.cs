using AITech.WebUI.DTOs.ProjectDtos;

namespace AITech.WebUI.Services.ProjectServices
{
    public class ProjectService : IProjectService
    {
        private readonly HttpClient _client;

        public ProjectService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7066/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateProjectDto projectDto)
        {
            
           await _client.PostAsJsonAsync("projects", projectDto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("projects/" + id);
        }

        public async Task<List<ResultProjectDto>> GetAllAsync()
        {
            var projects = await _client.GetFromJsonAsync<List<ResultProjectDto>>("projects/WithCategories");
            return projects;
        }

        public async Task<UpdateProjectDto> GetByIdAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateProjectDto>("projects/" + id);
        }

        public async Task UpdateAsync(UpdateProjectDto projectDto)
        {
            await _client.PutAsJsonAsync("projects", projectDto);
        }
    }
}
