using AITech.WebUI.DTOs.FaqDtos;

namespace AITech.WebUI.Services.FaqServices
{
    public interface IFaqService
    {
        Task<List<ResultFaqDto>> GetAllAsync();
        Task<UpdateFaqDto> GetByIdAsync(int id);
        Task CreateAsync(CreateFaqDto faqDto);
        Task UpdateAsync(UpdateFaqDto faqDto);
        Task DeleteAsync(int id);
    }
}
