using AITech.DataAccess.Context;
using AITech.DataAccess.Repositories.GenericRepositories;
using AITech.Entity.Entities;

namespace AITech.DataAccess.Repositories.AboutRepositories
{
    public class AboutRepository : GenericRepository<About>, IAboutRepository
    {
        public AboutRepository(AppDbContext context) : base(context)
        {
        }
    }
}
