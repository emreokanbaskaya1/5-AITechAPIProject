using AITech.WebUI.DTOs.ProjectDtos;
using FluentValidation;

namespace AITech.WebUI.Validators
{
    public class ProjectValidator: AbstractValidator<CreateProjectDto>
    {
        public ProjectValidator()
        {
            RuleFor(x=>x.Title).NotEmpty().WithMessage("Title is required").MaximumLength(100).WithMessage("Title cannot exceed 100 characters");
            RuleFor(x=>x.ImageUrl).NotEmpty().WithMessage("Description is required");
            RuleFor(x=>x.CategoryId).NotEmpty().WithMessage("Description is required");
        }
    }
}
