using AITech.DataAccess.Repositories.AboutItemRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.AboutItemDtos;
using AITech.Entity.Entities;
using Mapster;

namespace AITech.Business.Services.AboutItemServices
{
    public class AboutItemService(IAboutItemRepository _aboutItemRepository, IUnitOfWork _unitOfWork) : IAboutItemService
    {
        public async Task TCreateAsync(CreateAboutItemDto createDto)
        {
            var aboutItem = createDto.Adapt<AboutItem>();
            await _aboutItemRepository.CreateAsync(aboutItem);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var aboutItem = await _aboutItemRepository.GetByIdAsync(id);
            _aboutItemRepository.Delete(aboutItem);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultAboutItemDto>> TGetAllAsync()
        {
            var aboutItems = await _aboutItemRepository.GetAllAsync();
            var result = aboutItems.Adapt<List<ResultAboutItemDto>>();
            return result;
        }

        public async Task<ResultAboutItemDto> TGetByIdAsync(int id)
        {
            var aboutItem = await _aboutItemRepository.GetByIdAsync(id);
            return aboutItem.Adapt<ResultAboutItemDto>();
        }

        public async Task TUpdateAsync(UpdateAboutItemDto updateDto)
        {
            var aboutItem = updateDto.Adapt<AboutItem>();
            _aboutItemRepository.Update(aboutItem);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
