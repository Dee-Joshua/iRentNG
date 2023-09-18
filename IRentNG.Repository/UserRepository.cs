using IRentNG.Contracts;
using IRentNG.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace IRentNG.Repository
{
    internal sealed class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void DeleteUser(User user) => Delete(user);

        public async Task<IEnumerable<User>> GetAllUsersAsync(bool trackChanges) => 
            await FindAll(trackChanges)
            .OrderBy(u => u.FullName)
            .ToListAsync();

        public async Task<User> GetUserAsync(string userId, bool trackChanges) =>
            await FindByCondition(u => u.Id.Equals(userId), trackChanges)
            .SingleOrDefaultAsync();

        public async Task<User> GetUserByEmailAsync(string email, bool trackChanges) =>
            await FindByCondition(u => u.Email.Equals(email), trackChanges)
            .SingleOrDefaultAsync();
    }
}
