using AITech.WebUI.DTOs.FaqDtos;

namespace AITech.WebUI.Services.FaqServices
{
    public class FaqService : IFaqService
    {
        private readonly HttpClient _client;

        public FaqService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7066/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateFaqDto faqDto)
        {
            await _client.PostAsJsonAsync("Faqs", faqDto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("Faqs/" + id);
        }

        public async Task<List<ResultFaqDto>> GetAllAsync()
        {
            var faqs = await _client.GetFromJsonAsync<List<ResultFaqDto>>("Faqs");
            return faqs;
        }

        public async Task<UpdateFaqDto> GetByIdAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateFaqDto>("Faqs/" + id);
        }

        public async Task UpdateAsync(UpdateFaqDto faqDto)
        {
            await _client.PutAsJsonAsync("Faqs", faqDto);
        }
    }
}
