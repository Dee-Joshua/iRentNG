using AutoMapper;
using IRentNG.Contracts;
using IRentNG.Entities.Exceptions;
using IRentNG.Entities.Models;
using IRentNG.Service.Contracts;
using IRentNG.Shared.DataTransferObjects;

namespace IRentNG.Service
{
    internal sealed class UserService : IUserService
    {
        private readonly IUnitOfWork _repository;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;

        public UserService(IUnitOfWork repository, IMapper mapper, ILoggerManager logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
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

        public async Task UpdateUserAsync(Guid userId, UserForUpdateDto userForUpdate, bool trackChanges)
        {
            var user = await GetUserAndCheckIfItExists(userId, trackChanges);

            _mapper.Map(userForUpdate, user);
            await _repository.SaveAsync();
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
