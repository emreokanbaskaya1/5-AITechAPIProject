using AITech.WebUI.DTOs.ChooseDtos;

namespace AITech.WebUI.Services.ChooseServices
{
    public interface IChooseService
    {
        Task<List<ResultChooseDto>> GetAllAsync();
        Task<UpdateChooseDto> GetByIdAsync(int id);
        Task CreateAsync(CreateChooseDto chooseDto);
        Task UpdateAsync(UpdateChooseDto chooseDto);
        Task DeleteAsync(int id);
    }
}
