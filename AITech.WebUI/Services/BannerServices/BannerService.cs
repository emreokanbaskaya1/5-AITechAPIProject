using AITech.WebUI.DTOs.BannerDtos;

namespace AITech.WebUI.Services.BannerServices
{
    public class BannerService : IBannerService
    {
        private readonly HttpClient _client;

        public BannerService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7066/api/");
            _client = client;
        }



        public async Task CreateAsync(CreateBannerDto BannerDto)
        {

            await _client.PostAsJsonAsync("Banners", BannerDto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("Banners/" + id);
        }

        public async Task<List<ResultBannerDto>> GetAllAsync()
        {
            var Banners = await _client.GetFromJsonAsync<List<ResultBannerDto>>("Banners");
            return Banners;
        }

        public async Task<UpdateBannerDto> GetByIdAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateBannerDto>("Banners/" + id);
        }

        public async Task UpdateAsync(UpdateBannerDto BannerDto)
        {
            await _client.PutAsJsonAsync("Banners", BannerDto);
        }
        public Task MakeActiveAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task MakePassiveAsync(int id)
        {
            throw new NotImplementedException();
        }

    }
}
