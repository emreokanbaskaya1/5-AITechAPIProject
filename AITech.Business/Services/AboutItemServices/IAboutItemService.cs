using AITech.Business.Services.GenericServices;
using AITech.DTO.AboutItemDtos;

namespace AITech.Business.Services.AboutItemServices
{
    public interface IAboutItemService : IGenericService<ResultAboutItemDto, CreateAboutItemDto, UpdateAboutItemDto>
    {
    }
}
