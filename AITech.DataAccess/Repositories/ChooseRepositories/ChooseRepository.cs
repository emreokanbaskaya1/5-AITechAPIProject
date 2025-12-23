using AITech.DataAccess.Context;
using AITech.DataAccess.Repositories.GenericRepositories;
using AITech.Entity.Entities;

namespace AITech.DataAccess.Repositories.ChooseRepositories
{
    public class ChooseRepository : GenericRepository<Choose>, IChooseRepository
    {
        public ChooseRepository(AppDbContext context) : base(context)
        {
        }
    }
}
