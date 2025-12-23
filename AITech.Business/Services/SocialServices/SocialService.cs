using AITech.DataAccess.Repositories.SocialRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.SocialDtos;
using AITech.Entity.Entities;
using Mapster;

namespace AITech.Business.Services.SocialServices
{
    public class SocialService(ISocialRepository _socialRepository, IUnitOfWork _unitOfWork) : ISocialService
    {
        public async Task TCreateAsync(CreateSocialDto createDto)
        {
            var social = createDto.Adapt<Social>();
            await _socialRepository.CreateAsync(social);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var social = await _socialRepository.GetByIdAsync(id);
            _socialRepository.Delete(social);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultSocialDto>> TGetAllAsync()
        {
            var socials = await _socialRepository.GetAllAsync();
            var result = socials.Adapt<List<ResultSocialDto>>();
            return result;
        }

        public async Task<ResultSocialDto> TGetByIdAsync(int id)
        {
            var social = await _socialRepository.GetByIdAsync(id);
            return social.Adapt<ResultSocialDto>();
        }

        public async Task TUpdateAsync(UpdateSocialDto updateDto)
        {
            var social = updateDto.Adapt<Social>();
            _socialRepository.Update(social);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
