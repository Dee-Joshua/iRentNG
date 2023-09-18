using IRentNG.Entities.Models;
using IRentNG.Repository.Extensions.Utility;
using System.Linq.Dynamic.Core;

namespace IRentNG.Repository.Extensions
{
    public static class RepositoryPropertyExtensions
    {
        public static IQueryable<Property> FilterProperties(this IQueryable<Property> properties, uint minPrice, uint maxPrice) =>
            properties.Where(p => (p.Price >= minPrice && p.Price <= maxPrice));

        public static IQueryable<Property> Search(this IQueryable<Property> properties, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return properties;

            var lowerCaseTerm = searchTerm.Trim().ToLower();

            return properties.Where(p => p.Description.ToLower().Contains(lowerCaseTerm));
        }

        public static IQueryable<Property> Sort(this IQueryable<Property> properties, string orderByQueryString)
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString))
                return properties.OrderBy(p => p.Title);

            var orderQuery = OrderQueryBuilder.CreateOrderQuery<Property>(orderByQueryString);

            if (string.IsNullOrWhiteSpace(orderQuery))
                return properties.OrderBy(p => p.Title);

            return properties.OrderBy(orderQuery);
        }
    }
}
