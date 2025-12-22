using AITech.Business.Services.AboutServices;
using AITech.DTO.AboutDtos;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController(IAboutService _aboutService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var abouts = await _aboutService.TGetAllAsync();
            return Ok(abouts);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var about = await _aboutService.TGetByIdAsync(id);
            return Ok(about);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateAboutDto aboutDto)
        {
            await _aboutService.TCreateAsync(aboutDto);
            return Created();
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateAboutDto aboutDto)
        {
            await _aboutService.TUpdateAsync(aboutDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _aboutService.TDeleteAsync(id);
            return Ok("About is deleted");
        }
    }
}
