using AITech.WebUI.DTOs.AboutItemDtos;

namespace AITech.WebUI.Services.AboutItemServices
{
    public class AboutItemService : IAboutItemService
    {
        private readonly HttpClient _client;

        public AboutItemService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7066/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateAboutItemDto aboutItemDto)
        {
            await _client.PostAsJsonAsync("AboutItems", aboutItemDto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("AboutItems/" + id);
        }

        public async Task<List<ResultAboutItemDto>> GetAllAsync()
        {
            var aboutItems = await _client.GetFromJsonAsync<List<ResultAboutItemDto>>("AboutItems");
            return aboutItems;
        }

        public async Task<UpdateAboutItemDto> GetByIdAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateAboutItemDto>("AboutItems/" + id);
        }

        public async Task UpdateAsync(UpdateAboutItemDto aboutItemDto)
        {
            await _client.PutAsJsonAsync("AboutItems", aboutItemDto);
        }
    }
}
