using IRentNG.Contracts;
using IRentNG.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace IRentNG.Repository
{
    internal sealed class PropertyRepository : RepositoryBase<Property>, IPropertyRepository
    {
        public PropertyRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreatePropertyForUser(string userId, Property property)
        {
            property.UserId = userId;
            Create(property);
        }

        public void DeleteProperty(Property property) => Delete(property);


        public async Task<IEnumerable<Property>> GetPropertiesAsync(string userId, bool trackChanges) => 
            await FindByCondition(p => p.UserId.Equals(userId), trackChanges)
            .OrderBy(p => p.Title)
            .ToListAsync();

        public async Task<Property> GetPropertyAsync(string userId, Guid id, bool trackChanges) =>
            await FindByCondition(p => p.UserId.Equals(userId) && p.Id.Equals(id), trackChanges)
            .SingleOrDefaultAsync();
    }
}
