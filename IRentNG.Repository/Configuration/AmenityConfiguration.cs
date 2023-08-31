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
                    Name = "None",                    
                },
                new Amenity
                {
                    Name = "Kitchen"
                },
                new Amenity
                {
                    Name = "Tv"
                },
                new Amenity
                {
                    Name = "Wifi",
                },
                new Amenity
                {
                    Name = "Washing Machine"
                },
                new Amenity
                {
                    Name = "Air Conditioning"
                },
                new Amenity
                {
                    Name = "Free Parking On Premises",
                },
                new Amenity
                {
                    Name = "Dedicated Workspace"
                },
                new Amenity
                {
                    Name = "Cinema"
                },
                new Amenity
                {
                    Name = "Pool",
                },
                new Amenity
                {
                    Name = "Hot Tub"
                },
                new Amenity
                {
                    Name = "Veranda"
                },
                new Amenity
                {
                    Name = "BBQ Grill",
                },
                new Amenity
                {
                    Name = "Pool Table"
                },
                new Amenity
                {
                    Name = "Piano"
                },
                new Amenity
                {
                    Name = "Exercise Equipment",
                },
                new Amenity
                {
                    Name = "Smoke Alarm"
                },
                new Amenity
                {
                    Name = "First Aid Kit"
                },
                new Amenity
                {
                    Name = "Fire Extinguisher",
                });
        }
    }
}
