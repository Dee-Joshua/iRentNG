using IRentNG.Contracts;
using IRentNG.Entities.Models;
using IRentNG.Shared.RequestFeatures;
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


        public async Task<PagedList<Property>> GetPropertiesAsync(string userId, PropertyParameters propertyParameters, bool trackChanges)
        {
            var properties = await FindByCondition(p => p.UserId.Equals(userId), trackChanges)
                .OrderBy(p => p.Title)
                .ToListAsync();

            return PagedList<Property>
                .ToPagedList(properties, propertyParameters.PageNumber, propertyParameters.PageSize);
        }

        public async Task<PagedList<Property>> GetAllPropertiesInDatabaseAsync(PropertyParameters propertyParameters, bool trackChanges)
        {
            var properties = await FindByCondition(p => p.Price >= propertyParameters.MinPrice &&  p.Price <= propertyParameters.MaxPrice, trackChanges)
                .OrderBy(p => p.Title)
                .Skip((propertyParameters.PageNumber - 1) * propertyParameters.PageSize)
                .Take(propertyParameters.PageSize)
                .ToListAsync();

            var count = await FindByCondition(p => p.Price >= propertyParameters.MinPrice && p.Price <= propertyParameters.MaxPrice, trackChanges).CountAsync();

            return new PagedList<Property>(properties, count, propertyParameters.PageNumber, propertyParameters.PageSize);
        }


        public async Task<Property> GetPropertyAsync(string userId, Guid id, bool trackChanges) =>
            await FindByCondition(p => p.UserId.Equals(userId) && p.Id.Equals(id), trackChanges)
            .SingleOrDefaultAsync();
    }
}
