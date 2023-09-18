using IRentNG.Shared.DataTransferObjects;
using IRentNG.Shared.RequestFeatures;
using Microsoft.AspNetCore.Http;

namespace IRentNG.Service.Contracts
{
    public interface IPropertyService
    {
        Task<(IEnumerable<PropertyDto> properties, MetaData metaData)> GetPropertiesAsync(Guid userId, PropertyParameters propertyParameters, bool trackChanges);
        Task<(IEnumerable<PropertyDto> properties, MetaData metaData)> GetAllPropertiesInDatabaseAsync(PropertyParameters propertyParameters, bool trackChanges);
        Task<ContactDto> GetLandlordContactForPropertyAsync(Guid id, bool trackChanges);
        Task<PropertyDto> GetPropertyAsync(Guid userId, Guid id, bool trackChanges);
        Task<PropertyDto> CreatePropertyForUserAsync(Guid userId, PropertyForCreationDto propertyForCreation, bool trackChanges);
        Task<PropertyDto> UploadCoverPhotoAsync(Guid userId, Guid id, IFormFile file, bool trackChanges);
        Task<PropertyDto> UploadPropertyPhotosAsync(Guid userId, Guid id, List<IFormFile> photos, bool trackChanges);
        Task<PropertyDto> AddPropertyAmenitiesAsync(Guid userId, Guid id, List<PropertyAmenitiesDto> amenities, bool trackChanges);
        Task DeletePropertyForUserAsync(Guid userId, Guid id, bool trackChanges);
        Task UpdatePropertyForUserAsync(Guid userId, Guid id, PropertyForUpdateDto propertyForUpdate, bool userTrackChanges, bool propTrackChanges);
        
    }
}
