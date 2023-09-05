using IRentNG.Shared.DataTransferObjects;

namespace IRentNG.Service.Contracts
{
    public interface IUserService
    {
        Task<IEnumerable<UserDto>> GetAllUsersAsync(bool trackChanges);
        Task<UserDto> GetUserAsync(Guid id, bool trackChanges);
        Task DeleteUserAsync(Guid userId, bool trackChanges);
        Task UpdateUserAsync(Guid userId, UserForUpdateDto userForUpdate, bool trackChanges);
    }
}
