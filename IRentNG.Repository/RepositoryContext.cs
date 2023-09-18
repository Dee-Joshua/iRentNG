using IRentNG.Entities.Models;
using IRentNG.Repository.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IRentNG.Repository
{
    public class RepositoryContext : IdentityDbContext<User>
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new RoleConfiguration());
            //builder.ApplyConfiguration(new AmenityConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new PropertyConfiguration());
        }

        public DbSet<Property> Properties { get; set; }
        //public DbSet<Amenity> Amenities { get; set; }
        //public DbSet<PropertyPhoto> PropertyPhotos { get; set; }
    }
}
