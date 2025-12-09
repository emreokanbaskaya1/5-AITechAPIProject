using AITech.DataAccess.Repositories.CategoryRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.CategoryDtos;
using AITech.Entity.Entities;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.Business.Services.CategoryServices
{
    public class CategoryService(ICategoryRepository _categoryRepository, IUnitOfWork _unitOfWork) : ICategoryService
    {
        public async Task TCreateAsync(CreateCategoryDto createDto)
        {
            var category = createDto.Adapt<Category>();
            await _categoryRepository.CreateAsync(category);
            _unitOfWork.SaveChangesAsync();
        }

        public Task TDeleteAsync(ResultCategoryDto resultDto)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultCategoryDto>> TGetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResultCategoryDto> TGetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task TUpdateAsync(UpdateCategoryDto updateDto)
        {
            throw new NotImplementedException();
        }
    }
}
