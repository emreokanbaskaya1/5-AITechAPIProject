using AITech.Business.Services.ChooseServices;
using AITech.DTO.ChooseDtos;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChoosesController(IChooseService _chooseService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var chooses = await _chooseService.TGetAllAsync();
            return Ok(chooses);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var choose = await _chooseService.TGetByIdAsync(id);
            return Ok(choose);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateChooseDto chooseDto)
        {
            await _chooseService.TCreateAsync(chooseDto);
            return Created();
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateChooseDto chooseDto)
        {
            await _chooseService.TUpdateAsync(chooseDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _chooseService.TDeleteAsync(id);
            return Ok("Choose item is deleted");
        }
    }
}
