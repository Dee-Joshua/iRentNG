using AutoMapper;
using IRentNG.Contracts;
using IRentNG.Entities.Enums;
using IRentNG.Entities.Exceptions;
using IRentNG.Entities.Models;
using IRentNG.Service.Contracts;
using IRentNG.Shared.DataTransferObjects;
using IRentNG.Shared.RequestFeatures;
using Microsoft.AspNetCore.Http;
using System.Text;

namespace IRentNG.Service
{
    internal sealed class PropertyService : IPropertyService
    {
        private readonly IUnitOfWork _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly IPhotoService _photoService;

        public PropertyService(IUnitOfWork repository, IMapper mapper, ILoggerManager logger, IPhotoService photoService)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
            _photoService = photoService;
        }

        public async Task<(IEnumerable<PropertyDto> properties, MetaData metaData)> GetPropertiesAsync(Guid userId, PropertyParameters propertyParameters, bool trackChanges)
        {
            await CheckIfUserExists(userId, trackChanges);

            var propertiesWithMetaData = await _repository.Property.GetPropertiesForUserAsync(userId.ToString(), propertyParameters, trackChanges);
            var propertyDto = _mapper.Map<IEnumerable<PropertyDto>>(propertiesWithMetaData);

            return (properties: propertyDto, metaData: propertiesWithMetaData.MetaData);
        }

        public async Task<(IEnumerable<PropertyDto> properties, MetaData metaData)> GetAllPropertiesInDatabaseAsync(PropertyParameters propertyParameters, bool trackChanges)
        {
            if (!propertyParameters.ValidPriceRange)
                throw new MaxPriceRangeBadRequestException();

            var propertiesWithMetaData = await _repository.Property.GetAllPropertiesInDatabaseAsync(propertyParameters, trackChanges);
            var propertyDto = _mapper.Map<IEnumerable<PropertyDto>>(propertiesWithMetaData);

            return (properties: propertyDto, metaData: propertiesWithMetaData.MetaData);
        }

        public async Task<ContactDto> GetLandlordContactForPropertyAsync(Guid id, bool trackChanges)
        {
            
            var propertyDb = await _repository.Property.GetPropertyAsync(id, trackChanges);
            if (propertyDb is null)
                throw new PropertyNotFoundException(id);

            var contactPerson = _mapper.Map<ContactDto>(propertyDb.User);
            return contactPerson;
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
            var propertyForUser = await _repository.Property.GetPropertyForUserAsync(userId.ToString(), id, trackChanges);
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

        public async Task<PropertyDto> UploadCoverPhotoAsync(Guid userId, Guid id, IFormFile file, bool trackChanges)
        {
            await CheckIfUserExists(userId, trackChanges);

            var propertyEntity = await GetPropertyForUserAndCheckIfItExists(userId, id, trackChanges);

            string coverPhotoURL = _photoService.UploadPhoto(file);

            if (coverPhotoURL is null)
                throw new PhotoFileUploadException();

            propertyEntity.CoverPhotoURL = coverPhotoURL;
            await _repository.SaveAsync();

            var propertyToReturn = _mapper.Map<PropertyDto>(propertyEntity);
            return propertyToReturn;
        }

        public async Task<PropertyDto> UploadPropertyPhotosAsync(Guid userId, Guid id, List<IFormFile> photos, bool trackChanges)
        {
            await CheckIfUserExists(userId, trackChanges);

            var propertyEntity = await GetPropertyForUserAndCheckIfItExists(userId, id, trackChanges);

            StringBuilder photoURLs = new StringBuilder();

            foreach (var photo in photos)
            {
                string photoString = _photoService.UploadPhoto(photo);

                photoURLs.Append(photoString); //Append current url

                //Check if it's not the last element before adding a comma separator
                if (photos.IndexOf(photo) < photos.Count - 1)
                    photoURLs.Append(", ");
            }

            string propertyPhotosURLs = photoURLs.ToString(); //Convert StringBuilder to a string
            if (propertyPhotosURLs is null)
                throw new PhotoFileUploadException();

            propertyEntity.PropertyPhotosURLs = propertyPhotosURLs;
            await _repository.SaveAsync();

            var propertyToReturn = _mapper.Map<PropertyDto>(propertyEntity);
            return propertyToReturn;
        }

        public async Task<PropertyDto> AddPropertyAmenitiesAsync(Guid userId, Guid id, List<PropertyAmenitiesDto> amenities, bool trackChanges)
        {
            await CheckIfUserExists(userId, trackChanges);

            var propertyEntity = await GetPropertyForUserAndCheckIfItExists(userId, id, trackChanges);

            StringBuilder amenitiesBuilder = new StringBuilder();

            foreach (var amenity in amenities)
            {
                amenitiesBuilder.Append(amenity.ToString()); //Append current amenity

                //Check if it's not the last element before adding a comma separator
                if (amenities.IndexOf(amenity) < amenities.Count - 1)
                    amenitiesBuilder.Append(", ");
            }

            string propertyAmenities = amenitiesBuilder.ToString(); //Convert StringBuilder to a string
            if (propertyAmenities is null)
                throw new ArgumentNullException(propertyAmenities, "You must add at least one amenity to your property");

            propertyEntity.PropertyAmenities = propertyAmenities;
            await _repository.SaveAsync();

            var propertyToReturn = _mapper.Map<PropertyDto>(propertyEntity);
            return propertyToReturn;
        }

    }
}
