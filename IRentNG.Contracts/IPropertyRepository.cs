using IRentNG.Entities.Models;
using IRentNG.Shared.RequestFeatures;

namespace IRentNG.Contracts
{
    public interface IPropertyRepository
    {
        Task<PagedList<Property>> GetPropertiesAsync(string userId, PropertyParameters propertyParameters, bool trackChanges);

        Task<PagedList<Property>> GetAllPropertiesInDatabaseAsync(PropertyParameters propertyParameters, bool trackChanges);

        Task<Property> GetPropertyAsync(string userId, Guid id, bool trackChanges);

        void CreatePropertyForUser(string userId, Property property);

        void DeleteProperty(Property property);
    }
}
