using IRentNG.Shared.DataTransferObjects;
using Microsoft.AspNetCore.Http;

namespace IRentNG.Service.Contracts
{
    public interface IUserService
    {
        Task<IEnumerable<UserDto>> GetAllUsersAsync(bool trackChanges);
        Task<UserDto> GetUserAsync(Guid id, bool trackChanges);
        Task<UserDto> GetUserByEmailAsync(string email, bool trackChanges);
        Task DeleteUserAsync(Guid userId, bool trackChanges);
        Task UpdateUserAsync(Guid userId, UserForUpdateDto userForUpdate, bool trackChanges);
        Task UpdateUserRoleToLandlordAsync(Guid id, UserForUpdateDto userForUpdate, IFormFile profilePicture, string role, bool trackChanges);
        Task<UserDto> UploadProfilePictureAsync(Guid userId,IFormFile photoFile, bool trackChanges);
    }
}
