using AutoMapper;
using IRentNG.Contracts;
using IRentNG.Service.Contracts;

namespace IRentNG.Service
{
    internal sealed class PropertyService : IPropertyService
    {
        private readonly IUnitOfWork _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public PropertyService(IUnitOfWork repository, IMapper mapper, ILoggerManager logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }
    }
}
