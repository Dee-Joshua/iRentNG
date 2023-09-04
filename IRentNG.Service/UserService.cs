using AutoMapper;
using IRentNG.Contracts;
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

        public async Task<IEnumerable<UserDto>> GetAllUsersAsync(bool trackChanges)
        {
            var users = await _repository.User.GetAllUsersAsync(trackChanges);
            var userDto = _mapper.Map<IEnumerable<UserDto>>(users);
            return userDto;
        }

        public async Task<UserDto> GetUserAsync(Guid id, bool trackChanges)
        {
            var user = await _repository.User.GetUserAsync(id.ToString(), trackChanges);

            var userDto = _mapper.Map<UserDto>(user);
            return userDto;
        }
    }
}
