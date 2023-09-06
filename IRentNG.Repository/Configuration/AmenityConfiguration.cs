using IRentNG.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IRentNG.Repository.Configuration
{
    public class AmenityConfiguration : IEntityTypeConfiguration<Amenity>
    {
        public void Configure(EntityTypeBuilder<Amenity> builder)
        {
            builder.HasData(
                new Amenity
                {
                    Id = 1,
                    Name = "None",                    
                },
                new Amenity
                {
                    Id = 2,
                    Name = "Kitchen"
                },
                new Amenity
                {
                    Id = 3,
                    Name = "Tv"
                },
                new Amenity
                {
                    Id = 4,
                    Name = "Wifi",
                },
                new Amenity
                {
                    Id = 5,
                    Name = "Washing Machine"
                },
                new Amenity
                {
                    Id = 6,
                    Name = "Air Conditioning"
                },
                new Amenity
                {
                    Id = 7,
                    Name = "Free Parking On Premises",
                },
                new Amenity
                {
                    Id = 8,
                    Name = "Dedicated Workspace"
                },
                new Amenity
                {
                    Id = 9,
                    Name = "Cinema"
                },
                new Amenity
                {
                    Id = 10,
                    Name = "Pool",
                },
                new Amenity
                {
                    Id= 11,
                    Name = "Hot Tub"
                },
                new Amenity
                {
                    Id = 12,
                    Name = "Veranda"
                },
                new Amenity
                {
                    Id = 13,
                    Name = "BBQ Grill",
                },
                new Amenity
                {
                    Id = 14,
                    Name = "Pool Table"
                },
                new Amenity
                {
                    Id = 15,
                    Name = "Piano"
                },
                new Amenity
                {
                    Id = 16,
                    Name = "Exercise Equipment",
                },
                new Amenity
                {
                    Id = 17,
                    Name = "Smoke Alarm"
                },
                new Amenity
                {
                    Id = 18,
                    Name = "First Aid Kit"
                },
                new Amenity
                {
                    Id = 19,
                    Name = "Fire Extinguisher",
                });
        }
    }
}
