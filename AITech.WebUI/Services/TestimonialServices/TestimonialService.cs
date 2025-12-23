using AITech.WebUI.DTOs.TestimonialDtos;

namespace AITech.WebUI.Services.TestimonialServices
{
    public class TestimonialService : ITestimonialService
    {
        private readonly HttpClient _client;

        public TestimonialService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7066/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateTestimonialDto testimonialDto)
        {
            await _client.PostAsJsonAsync("Testimonials", testimonialDto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("Testimonials/" + id);
        }

        public async Task<List<ResultTestimonialDto>> GetAllAsync()
        {
            var testimonials = await _client.GetFromJsonAsync<List<ResultTestimonialDto>>("Testimonials");
            return testimonials;
        }

        public async Task<UpdateTestimonialDto> GetByIdAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateTestimonialDto>("Testimonials/" + id);
        }

        public async Task UpdateAsync(UpdateTestimonialDto testimonialDto)
        {
            await _client.PutAsJsonAsync("Testimonials", testimonialDto);
        }
    }
}
