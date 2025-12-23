using AITech.Business.Services.GenericServices;
using AITech.DTO.FaqDtos;

namespace AITech.Business.Services.FaqServices
{
    public interface IFaqService : IGenericService<ResultFaqDto, CreateFaqDto, UpdateFaqDto>
    {
    }
}
