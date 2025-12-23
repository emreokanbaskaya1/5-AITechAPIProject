using AITech.DataAccess.Repositories.FeatureRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.FeatureDtos;
using AITech.Entity.Entities;
using Mapster;

namespace AITech.Business.Services.FeatureServices
{
    public class FeatureService(IFeatureRepository _featureRepository, IUnitOfWork _unitOfWork) : IFeatureService
    {
        public async Task TCreateAsync(CreateFeatureDto createDto)
        {
            var feature = createDto.Adapt<Feature>();
            await _featureRepository.CreateAsync(feature);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var feature = await _featureRepository.GetByIdAsync(id);
            _featureRepository.Delete(feature);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultFeatureDto>> TGetAllAsync()
        {
            var features = await _featureRepository.GetAllAsync();
            var result = features.Adapt<List<ResultFeatureDto>>();
            return result;
        }

        public async Task<ResultFeatureDto> TGetByIdAsync(int id)
        {
            var feature = await _featureRepository.GetByIdAsync(id);
            return feature.Adapt<ResultFeatureDto>();
        }

        public async Task TUpdateAsync(UpdateFeatureDto updateDto)
        {
            var feature = updateDto.Adapt<Feature>();
            _featureRepository.Update(feature);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
