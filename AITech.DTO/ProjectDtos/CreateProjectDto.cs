namespace AITech.DTO.ProjectDtos
{
    public record class CreateProjectDto(int Id,
                                         string Title,
                                         string ImageUrl,
                                         int CategoryId);
    
}
