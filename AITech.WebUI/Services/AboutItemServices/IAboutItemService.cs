using AITech.WebUI.DTOs.AboutItemDtos;

namespace AITech.WebUI.Services.AboutItemServices
{
    public interface IAboutItemService
    {
        Task<List<ResultAboutItemDto>> GetAllAsync();
        Task<UpdateAboutItemDto> GetByIdAsync(int id);
        Task CreateAsync(CreateAboutItemDto aboutItemDto);
        Task UpdateAsync(UpdateAboutItemDto aboutItemDto);
        Task DeleteAsync(int id);
    }
}
