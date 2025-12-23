using AITech.Business.Services.FaqServices;
using AITech.DTO.FaqDtos;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FaqsController(IFaqService _faqService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var faqs = await _faqService.TGetAllAsync();
            return Ok(faqs);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var faq = await _faqService.TGetByIdAsync(id);
            return Ok(faq);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateFaqDto faqDto)
        {
            await _faqService.TCreateAsync(faqDto);
            return Created();
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateFaqDto faqDto)
        {
            await _faqService.TUpdateAsync(faqDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _faqService.TDeleteAsync(id);
            return Ok("FAQ is deleted");
        }
    }
}
