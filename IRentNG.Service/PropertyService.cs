using AutoMapper;
using IRentNG.Contracts;
using IRentNG.Entities.Exceptions;
using IRentNG.Entities.Models;
using IRentNG.Service.Contracts;
using IRentNG.Shared.DataTransferObjects;

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

        public async Task<IEnumerable<PropertyDto>> GetPropertiesAsync(Guid userId, bool trackChanges)
        {
            await CheckIfUserExists(userId, trackChanges);

            var propertyFromDb = await _repository.Property.GetPropertiesAsync(userId.ToString(), trackChanges);

            var propertyDto = _mapper.Map<IEnumerable<PropertyDto>>(propertyFromDb);
            return propertyDto;
        }

        public async Task<PropertyDto> GetPropertyAsync(Guid userId, Guid id, bool trackChanges)
        {
            await CheckIfUserExists(userId, trackChanges);

            var propertyDb = await GetPropertyForUserAndCheckIfItExists(userId, id, trackChanges);

            var property = _mapper.Map<PropertyDto>(propertyDb);
            return property;
        }

        private async Task<Property> GetPropertyForUserAndCheckIfItExists(Guid userId, Guid id, bool trackChanges)
        {
            var propertyForUser = await _repository.Property.GetPropertyAsync(userId.ToString(), id, trackChanges);
            if (propertyForUser is null)
                throw new PropertyNotFoundException(id);
            return propertyForUser;
        }

        private async Task CheckIfUserExists(Guid userId, bool trackChanges)
        {
            var user = await _repository.User.GetUserAsync(userId.ToString(), trackChanges);
            if (user is null)
                throw new UserNotFoundException(userId);
        }

        public async Task<PropertyDto> CreatePropertyForUserAsync(Guid userId, PropertyForCreationDto propertyForCreation, bool trackChanges)
        {
            await CheckIfUserExists(userId, trackChanges);

            var propertyEntity = _mapper.Map<Property>(propertyForCreation);

            _repository.Property.CreatePropertyForUser(userId.ToString(), propertyEntity);
            await _repository.SaveAsync();

            var propertyToReturn = _mapper.Map<PropertyDto>(propertyEntity);
            return propertyToReturn;
        }

        public async Task DeletePropertyForUserAsync(Guid userId, Guid id, bool trackChanges)
        {
            await CheckIfUserExists(userId, trackChanges);

            var propertyForUser = await GetPropertyForUserAndCheckIfItExists(userId, id, trackChanges);

            _repository.Property.DeleteProperty(propertyForUser);
            await _repository.SaveAsync();
        }

        public async Task UpdatePropertyForUserAsync(Guid userId, Guid id, PropertyForUpdateDto propertyForUpdate, bool userTrackChanges, bool propTrackChanges)
        {
            await CheckIfUserExists(userId, userTrackChanges);

            var propertyEntity = await GetPropertyForUserAndCheckIfItExists(userId, id, propTrackChanges);

            _mapper.Map(propertyForUpdate, propertyEntity);
            await _repository.SaveAsync();
        }
    }
}
