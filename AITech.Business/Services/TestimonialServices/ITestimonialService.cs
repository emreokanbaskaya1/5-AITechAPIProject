using AITech.Business.Services.GenericServices;
using AITech.DTO.TestimonialDtos;

namespace AITech.Business.Services.TestimonialServices
{
    public interface ITestimonialService : IGenericService<ResultTestimonialDto, CreateTestimonialDto, UpdateTestimonialDto>
    {
    }
}
