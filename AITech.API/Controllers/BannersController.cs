using AITech.Business.Services.BannerServices;
using AITech.DTO.BannerDtos;
using AITech.DTO.CategoryDtos;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannersController(IBannerService _bannerService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var banners = await _bannerService.TGetAllAsync();
            return Ok(banners);
        }

        //localhost:7000/api/categories/1 (id)
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var banner = await _bannerService.TGetByIdAsync(id);
            return Ok(banner);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateBannerDto bannerDto)
        {
            await _bannerService.TCreateAsync(bannerDto);
            return Created();
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateBannerDto categoryDto)
        {
            await _bannerService.TUpdateAsync(categoryDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _bannerService.TDeleteAsync(id);
            return Ok("Banner is deleted");
        }

        [HttpPatch("makeActive/{id}")]
        public async Task<IActionResult> MakeActive(int id)
        {
            await _bannerService.TMakeActiveAsync(id);
            return NoContent();
        }

        [HttpPatch("makePassive/{id}")]
        public async Task<IActionResult> MakePassive(int id)
        {
            await _bannerService.TMakePassiveAsync(id);
            return NoContent();
        }
    }
}
