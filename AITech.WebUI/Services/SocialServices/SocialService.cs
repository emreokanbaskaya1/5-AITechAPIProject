using AITech.WebUI.DTOs.SocialDtos;

namespace AITech.WebUI.Services.SocialServices
{
    public class SocialService : ISocialService
    {
        private readonly HttpClient _client;

        public SocialService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7066/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateSocialDto socialDto)
        {
            await _client.PostAsJsonAsync("Socials", socialDto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("Socials/" + id);
        }

        public async Task<List<ResultSocialDto>> GetAllAsync()
        {
            var socials = await _client.GetFromJsonAsync<List<ResultSocialDto>>("Socials");
            return socials;
        }

        public async Task<UpdateSocialDto> GetByIdAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateSocialDto>("Socials/" + id);
        }

        public async Task UpdateAsync(UpdateSocialDto socialDto)
        {
            await _client.PutAsJsonAsync("Socials", socialDto);
        }
    }
}
