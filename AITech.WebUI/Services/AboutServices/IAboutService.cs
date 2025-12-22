using AITech.WebUI.DTOs.AboutDtos;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AITech.WebUI.Services.AboutServices
{
    public interface IAboutService
    {
        Task<List<ResultAboutDto>> GetAllAsync();
        Task<UpdateAboutDto> GetByIdAsync(int id);
        Task CreateAsync(CreateAboutDto aboutDto);
        Task UpdateAsync(UpdateAboutDto aboutDto);
        Task DeleteAsync(int id);
    }
}
