using IRentNG.Contracts;
using IRentNG.Entities.Models;

namespace IRentNG.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
