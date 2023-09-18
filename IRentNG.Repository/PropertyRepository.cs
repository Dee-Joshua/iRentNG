using IRentNG.Contracts;
using IRentNG.Entities.Models;
using IRentNG.Repository.Extensions;
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


        public async Task<PagedList<Property>> GetPropertiesForUserAsync(string userId, PropertyParameters propertyParameters, bool trackChanges)
        {
            var properties = await FindByCondition(p => p.UserId.Equals(userId), trackChanges)
                .OrderBy(p => p.Title)
                .ToListAsync();

            return PagedList<Property>
                .ToPagedList(properties, propertyParameters.PageNumber, propertyParameters.PageSize);
        }

        public async Task<PagedList<Property>> GetAllPropertiesInDatabaseAsync(PropertyParameters propertyParameters, bool trackChanges)
        {
            var properties = await FindAll(trackChanges)
                .Skip((propertyParameters.PageNumber-1)*propertyParameters.PageSize).Take(propertyParameters.PageSize)
                .FilterProperties(propertyParameters.MinPrice, propertyParameters.MaxPrice)
                .Search(propertyParameters.SearchTerm)
                .Sort(propertyParameters.OrderBy)
                .ToListAsync();

            var count = await FindByCondition(p => p.Price >= propertyParameters.MinPrice && p.Price <= propertyParameters.MaxPrice, trackChanges).CountAsync();

            return new PagedList<Property>(properties, count, propertyParameters.PageNumber, propertyParameters.PageSize);
        }

        public async Task<Property> GetPropertyAsync(Guid id, bool trackChanges) => 
            await FindByCondition(p => p.Id.Equals(id), trackChanges)
            .SingleOrDefaultAsync();

        public async Task<Property> GetPropertyForUserAsync(string userId, Guid id, bool trackChanges) =>
            await FindByCondition(p => p.UserId.Equals(userId) && p.Id.Equals(id), trackChanges)
            .SingleOrDefaultAsync();

        
    }
}
