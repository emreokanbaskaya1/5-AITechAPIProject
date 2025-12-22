using AITech.WebUI.DTOs.AboutDtos;

namespace AITech.WebUI.Services.AboutServices
{
    public class AboutService : IAboutService
    {
        private readonly HttpClient _client;

        public AboutService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7066/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateAboutDto aboutDto)
        {
            await _client.PostAsJsonAsync("Abouts", aboutDto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("Abouts/" + id);
        }

        public async Task<List<ResultAboutDto>> GetAllAsync()
        {
            var abouts = await _client.GetFromJsonAsync<List<ResultAboutDto>>("Abouts");
            return abouts;
        }

        public async Task<UpdateAboutDto> GetByIdAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateAboutDto>("Abouts/" + id);
        }

        public async Task UpdateAsync(UpdateAboutDto aboutDto)
        {
            await _client.PutAsJsonAsync("Abouts", aboutDto);
        }
    }
}
