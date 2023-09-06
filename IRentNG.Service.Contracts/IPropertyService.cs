using IRentNG.Shared.DataTransferObjects;
using IRentNG.Shared.RequestFeatures;

namespace IRentNG.Service.Contracts
{
    public interface IPropertyService
    {
        Task<(IEnumerable<PropertyDto> properties, MetaData metaData)> GetPropertiesAsync(Guid userId, PropertyParameters propertyParameters, bool trackChanges);
        Task<(IEnumerable<PropertyDto> properties, MetaData metaData)> GetAllPropertiesInDatabaseAsync(PropertyParameters propertyParameters, bool trackChanges);
        Task<PropertyDto> GetPropertyAsync(Guid userId, Guid id, bool trackChanges);
        Task<PropertyDto> CreatePropertyForUserAsync(Guid userId, PropertyForCreationDto propertyForCreation, bool trackChanges);
        Task DeletePropertyForUserAsync(Guid userId, Guid id, bool trackChanges);
        Task UpdatePropertyForUserAsync(Guid userId, Guid id, PropertyForUpdateDto propertyForUpdate, bool userTrackChanges, bool propTrackChanges);
    }
}
