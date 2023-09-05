using IRentNG.Shared.DataTransferObjects;

namespace IRentNG.Service.Contracts
{
    public interface IPropertyService
    {
        Task<IEnumerable<PropertyDto>> GetPropertiesAsync(Guid userId, bool trackChanges);
        Task<PropertyDto> GetPropertyAsync(Guid userId, Guid id, bool trackChanges);
    }
}
