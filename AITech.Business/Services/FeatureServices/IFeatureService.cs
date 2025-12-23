using AITech.Business.Services.GenericServices;
using AITech.DTO.FeatureDtos;

namespace AITech.Business.Services.FeatureServices
{
    public interface IFeatureService : IGenericService<ResultFeatureDto, CreateFeatureDto, UpdateFeatureDto>
    {
    }
}
