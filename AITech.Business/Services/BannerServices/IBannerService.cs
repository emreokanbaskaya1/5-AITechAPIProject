using AITech.Business.Services.GenericServices;
using AITech.DTO.BannerDtos;
using AITech.Entity.Entities;

namespace AITech.Business.Services.BannerServices
{
    public interface IBannerService: IGenericService<ResultBannerDto, CreateBannerDto, UpdateBannerDto>
    {
        Task TMakeActiveAsync(int id);
        Task TMakePassiveAsync(int id);



    }
}
