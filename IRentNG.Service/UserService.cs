using AutoMapper;
using IRentNG.Contracts;
using IRentNG.Service.Contracts;

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
    }
}
