using AITech.Business.Services.GenericServices;
using AITech.DTO.AboutDtos;

namespace AITech.Business.Services.AboutServices
{
    public interface IAboutService : IGenericService<ResultAboutDto, CreateAboutDto, UpdateAboutDto>
    {
    }
}
