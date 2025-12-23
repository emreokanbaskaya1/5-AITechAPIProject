using AITech.DataAccess.Repositories.FaqRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.FaqDtos;
using AITech.Entity.Entities;
using Mapster;

namespace AITech.Business.Services.FaqServices
{
    public class FaqService(IFaqRepository _faqRepository, IUnitOfWork _unitOfWork) : IFaqService
    {
        public async Task TCreateAsync(CreateFaqDto createDto)
        {
            var faq = createDto.Adapt<FAQ>();
            await _faqRepository.CreateAsync(faq);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var faq = await _faqRepository.GetByIdAsync(id);
            _faqRepository.Delete(faq);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultFaqDto>> TGetAllAsync()
        {
            var faqs = await _faqRepository.GetAllAsync();
            var result = faqs.Adapt<List<ResultFaqDto>>();
            return result;
        }

        public async Task<ResultFaqDto> TGetByIdAsync(int id)
        {
            var faq = await _faqRepository.GetByIdAsync(id);
            return faq.Adapt<ResultFaqDto>();
        }

        public async Task TUpdateAsync(UpdateFaqDto updateDto)
        {
            var faq = updateDto.Adapt<FAQ>();
            _faqRepository.Update(faq);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
