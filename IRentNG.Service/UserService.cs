using AutoMapper;
using IRentNG.Contracts;
using IRentNG.Entities.Exceptions;
using IRentNG.Entities.Models;
using IRentNG.Service.Contracts;
using IRentNG.Shared.DataTransferObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace IRentNG.Service
{
    internal sealed class UserService : IUserService
    {
        private readonly IUnitOfWork _repository;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;
        private readonly UserManager<User> _userManger;
        private readonly IPhotoService _photoService;

        public UserService(IUnitOfWork repository, IMapper mapper, ILoggerManager logger, UserManager<User> userManger, IPhotoService photoService)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
            _userManger = userManger;
            _photoService = photoService;
        }

        public async Task DeleteUserAsync(Guid userId, bool trackChanges)
        {
            var user = await GetUserAndCheckIfItExists(userId, trackChanges);

            _repository.User.DeleteUser(user);
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<UserDto>> GetAllUsersAsync(bool trackChanges)
        {
            var users = await _repository.User.GetAllUsersAsync(trackChanges);
            var userDto = _mapper.Map<IEnumerable<UserDto>>(users);
            return userDto;
        }

        public async Task<UserDto> GetUserAsync(Guid id, bool trackChanges)
        {
            User user = await GetUserAndCheckIfItExists(id, trackChanges);

            var userDto = _mapper.Map<UserDto>(user);
            return userDto;
        }

        public async Task<UserDto> GetUserByEmailAsync(string email, bool trackChanges)
        {
            User user = await _repository.User.GetUserByEmailAsync(email, trackChanges);//GetUserAsync(id.ToString(), trackChanges);
            if (user is null)
                throw new UserNotFoundException(email);

            var userDto = _mapper.Map<UserDto>(user);
            return userDto;
        }

        public async Task UpdateUserAsync(Guid userId, UserForUpdateDto userForUpdate, bool trackChanges)
        {
            var user = await GetUserAndCheckIfItExists(userId, trackChanges);

            _mapper.Map(userForUpdate, user);
            await _repository.SaveAsync();

        }

        public async Task UpdateUserRoleToLandlordAsync(Guid id, UserForUpdateDto userForUpdate, IFormFile profilePicture, string role, bool trackChanges)
        {
            var user = await GetUserAndCheckIfItExists(id, trackChanges);

            _mapper.Map(userForUpdate, user);
            await _userManger.AddToRoleAsync(user, role);
            string profilePictureURL = _photoService.UploadPhoto(profilePicture);
            if (profilePictureURL is null)
                throw new PhotoFileUploadException();
            user.ProfilePicture = profilePictureURL;
            await _repository.SaveAsync();
        }


        public async Task<UserDto> UploadProfilePictureAsync(Guid userId, IFormFile photoFile, bool trackChanges)
        {
            var user = await GetUserAndCheckIfItExists(userId, trackChanges);

            string profilePictureURL = _photoService.UploadPhoto(photoFile);

            if (profilePictureURL is null)
                throw new PhotoFileUploadException();

            user.ProfilePicture = profilePictureURL;
            await _repository.SaveAsync();

            var userToReturn = _mapper.Map<UserDto>(user);
            return userToReturn;
        }

        private async Task<User> GetUserAndCheckIfItExists(Guid id, bool trackChanges)
        {
            var userFromDatabase = await _repository.User.GetUserAsync(id.ToString(), trackChanges);
            if (userFromDatabase is null)
                throw new UserNotFoundException(id);
            return userFromDatabase;
        }
    }
}
