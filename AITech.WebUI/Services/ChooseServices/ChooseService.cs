using AITech.WebUI.DTOs.ChooseDtos;

namespace AITech.WebUI.Services.ChooseServices
{
    public class ChooseService : IChooseService
    {
        private readonly HttpClient _client;

        public ChooseService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7066/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateChooseDto chooseDto)
        {
            await _client.PostAsJsonAsync("Chooses", chooseDto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("Chooses/" + id);
        }

        public async Task<List<ResultChooseDto>> GetAllAsync()
        {
            var chooses = await _client.GetFromJsonAsync<List<ResultChooseDto>>("Chooses");
            return chooses;
        }

        public async Task<UpdateChooseDto> GetByIdAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateChooseDto>("Chooses/" + id);
        }

        public async Task UpdateAsync(UpdateChooseDto chooseDto)
        {
            await _client.PutAsJsonAsync("Chooses", chooseDto);
        }
    }
}
