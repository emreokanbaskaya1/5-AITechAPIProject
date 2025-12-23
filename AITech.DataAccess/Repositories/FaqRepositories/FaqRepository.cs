using AITech.DataAccess.Context;
using AITech.DataAccess.Repositories.GenericRepositories;
using AITech.Entity.Entities;

namespace AITech.DataAccess.Repositories.FaqRepositories
{
    public class FaqRepository : GenericRepository<FAQ>, IFaqRepository
    {
        public FaqRepository(AppDbContext context) : base(context)
        {
        }
    }
}
