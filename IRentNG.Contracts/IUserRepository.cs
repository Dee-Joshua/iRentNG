using IRentNG.Entities.Models;

namespace IRentNG.Contracts
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUsersAsync(bool trackChanges);
        Task<User> GetUserAsync(string userId, bool trackChanges);
        Task<User> GetUserByEmailAsync(string email, bool trackChanges);
        void DeleteUser(User user);
    }
}
