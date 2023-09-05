using IRentNG.Shared.DataTransferObjects;

namespace IRentNG.Service.Contracts
{
    public interface IPropertyService
    {
        Task<IEnumerable<PropertyDto>> GetPropertiesAsync(Guid userId, bool trackChanges);
        Task<PropertyDto> GetPropertyAsync(Guid userId, Guid id, bool trackChanges);
        Task<PropertyDto> CreatePropertyForUserAsync(Guid userId, PropertyForCreationDto propertyForCreation, bool trackChanges);
        Task DeletePropertyForUserAsync(Guid userId, Guid id, bool trackChanges);
        Task UpdatePropertyForUserAsync(Guid userId, Guid id, PropertyForUpdateDto propertyForUpdate, bool userTrackChanges, bool propTrackChanges);
    }
}
