using AITech.Business.Services.GenericServices;
using AITech.DTO.SocialDtos;

namespace AITech.Business.Services.SocialServices
{
    public interface ISocialService : IGenericService<ResultSocialDto, CreateSocialDto, UpdateSocialDto>
    {
    }
}
