using AITech.DataAccess.Context;
using AITech.DataAccess.Repositories.GenericRepositories;
using AITech.Entity.Entities;

namespace AITech.DataAccess.Repositories.AboutItemRepositories
{
    public class AboutItemRepository : GenericRepository<AboutItem>, IAboutItemRepository
    {
        public AboutItemRepository(AppDbContext context) : base(context)
        {
        }
    }
}
