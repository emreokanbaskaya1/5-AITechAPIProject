using AITech.Business.Services.AboutItemServices;
using AITech.DTO.AboutItemDtos;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutItemsController(IAboutItemService _aboutItemService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var aboutItems = await _aboutItemService.TGetAllAsync();
            return Ok(aboutItems);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var aboutItem = await _aboutItemService.TGetByIdAsync(id);
            return Ok(aboutItem);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateAboutItemDto aboutItemDto)
        {
            await _aboutItemService.TCreateAsync(aboutItemDto);
            return Created();
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateAboutItemDto aboutItemDto)
        {
            await _aboutItemService.TUpdateAsync(aboutItemDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _aboutItemService.TDeleteAsync(id);
            return Ok("About item is deleted");
        }
    }
}
