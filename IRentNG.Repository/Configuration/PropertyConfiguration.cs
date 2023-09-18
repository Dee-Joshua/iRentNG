using IRentNG.Entities.Enums;
using IRentNG.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IRentNG.Repository.Configuration
{
    public class PropertyConfiguration : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> builder)
        {
            builder.HasData(
                new Property
                {
                    Id = Guid.NewGuid(),
                    Title = "Luxury Apartment in Lagos Island",
                    Description = "Experience luxury living in this spacious apartment located in the heart of Lagos Island. This stunning three-bedroom apartment features a modern kitchen, beautiful city views, and access to top-notch amenities.",
                    Address = "1 Victoria Island, Lagos",
                    Structure = PropertyType.Apartment,
                    Privacy = PrivacyType.EntirePlace,
                    Bedrooms = 3,
                    Bathrooms = 2,
                    PropertyAmenities = "Kitchen, Wifi, AirConditioning, FreeParkingOnPremises",
                    Price = 2500000.00m, // Yearly rent in NGN
                    Duration = RentInterval.Yearly,
                    CoverPhotoURL = "https://example.com/property1-cover.jpg",
                    PropertyPhotosURLs = "https://example.com/property1-photo1.jpg,https://example.com/property1-photo2.jpg",
                    CreatedDate = DateTime.Now,
                    UserId = "9FE6F8FB-CE97-4DAE-AE02-0B3AC6B114FA",
                },
                new Property
                {
                    Id = Guid.NewGuid(),
                    Title = "Luxury Villa in Abuja",
                    Description = "Indulge in luxury at this stunning villa in Abuja. This spacious five-bedroom villa features a private pool, lush gardens, and a fully equipped kitchen. Perfect for special events or a relaxing getaway.",
                    Address = "12 Garki, Abuja",
                    Structure = PropertyType.Mansion,
                    Privacy = PrivacyType.EntirePlace,
                    Bedrooms = 5,
                    Bathrooms = 4,
                    PropertyAmenities = "Kitchen, Tv, Wifi, AirConditioning, Pool, BBQGrill",
                    Price = 5000000.00m, // Yearly rent in NGN
                    Duration = RentInterval.Yearly,
                    CoverPhotoURL = "https://example.com/property2-cover.jpg",
                    PropertyPhotosURLs = "https://example.com/property2-photo1.jpg,https://example.com/property2-photo2.jpg",
                    CreatedDate = DateTime.Now,
                    UserId = "9FE6F8FB-CE97-4DAE-AE02-0B3AC6B114FA",
                },
                new Property
                {
                    Id = Guid.NewGuid(),
                    Title = "Spacious Apartment in Victoria Island",
                    Description = "A spacious apartment with 3 bedrooms, 2 bathrooms, and a stunning view of the ocean. Located in the upscale Victoria Island neighborhood, this property offers luxury living, a fully equipped kitchen, and access to a private pool and gym.",
                    Address = "3 Ocean View Drive, Victoria Island",
                    Structure = PropertyType.Apartment,
                    Privacy = PrivacyType.EntirePlace,
                    Bedrooms = 3,
                    Bathrooms = 2,
                    PropertyAmenities = "Kitchen, Tv, Wifi, AirConditioning, Pool, Gym",
                    Price = 3500000.00m, // Monthly rent in NGN
                    Duration = RentInterval.Yearly,
                    CoverPhotoURL = "https://example.com/property3-cover.jpg",
                    PropertyPhotosURLs = "https://example.com/property3-photo1.jpg,https://example.com/property3-photo2.jpg",
                    CreatedDate = DateTime.Now,
                    UserId = "9FE6F8FB-CE97-4DAE-AE02-0B3AC6B114FA",
                },
                new Property
                {
                    Id = Guid.NewGuid(),
                    Title = "Modern Terrace Duplex in Lekki",
                    Description = "A modern terrace duplex with 4 bedrooms, 3 bathrooms, and contemporary design. This property is situated in the trendy Lekki neighborhood and offers spacious rooms, a sleek kitchen, and a rooftop terrace with stunning views.",
                    Address = "4 Lekki Gardens, Lekki",
                    Structure = PropertyType.TerraceDuplex,
                    Privacy = PrivacyType.EntirePlace,
                    Bedrooms = 4,
                    Bathrooms = 3,
                    PropertyAmenities = "Kitchen, Tv, Wifi, AirConditioning, RooftopTerrace",
                    Price = 600000.00m, // Monthly rent in NGN
                    Duration = RentInterval.Monthly,
                    CoverPhotoURL = "https://example.com/property4-cover.jpg",
                    PropertyPhotosURLs = "https://example.com/property4-photo1.jpg,https://example.com/property4-photo2.jpg",
                    CreatedDate = DateTime.Now,
                    UserId = "9FE6F8FB-CE97-4DAE-AE02-0B3AC6B114FA",
                },
                new Property
                {
                    Id = Guid.NewGuid(),
                    Title = "Charming Guest House in Calabar",
                    Description = "A charming guest house with 6 cozy rooms, each with its own bathroom. This guest house is located in the beautiful city of Calabar and offers a garden, free Wi-Fi, and a dedicated workspace. Perfect for travelers.",
                    Address = "5 Calabar Lane, Calabar",
                    Structure = PropertyType.GuestHouse,
                    Privacy = PrivacyType.EntirePlace,
                    Bedrooms = 6,
                    Bathrooms = 6,
                    PropertyAmenities = "Kitchen, Tv, Wifi, DedicatedWorkspace, Garden",
                    Price = 450000.00m, // Monthly rent in NGN
                    Duration = RentInterval.Monthly,
                    CoverPhotoURL = "https://example.com/property5-cover.jpg",
                    PropertyPhotosURLs = "https://example.com/property5-photo1.jpg,https://example.com/property5-photo2.jpg",
                    CreatedDate = DateTime.Now,
                    UserId = "826E0C43-871D-4498-B343-8F8260E1127C",
                },
                new Property
                {
                    Id = Guid.NewGuid(),
                    Title = "Luxurious Penthouse in Lagos",
                    Description = "Experience luxury living in this spacious penthouse with 5 bedrooms, 4 bathrooms, and breathtaking views of Lagos. This penthouse features a gourmet kitchen, private elevator access, and access to a rooftop pool and lounge.",
                    Address = "6 Marina Drive, Lagos",
                    Structure = PropertyType.PentHouse,
                    Privacy = PrivacyType.EntirePlace,
                    Bedrooms = 5,
                    Bathrooms = 4,
                    PropertyAmenities = "Kitchen, Tv, Wifi, AirConditioning, RooftopPool",
                    Price = 1000000.00m, // Monthly rent in NGN
                    Duration = RentInterval.Monthly,
                    CoverPhotoURL = "https://example.com/property6-cover.jpg",
                    PropertyPhotosURLs = "https://example.com/property6-photo1.jpg,https://example.com/property6-photo2.jpg",
                    CreatedDate = DateTime.Now,
                    UserId = "826E0C43-871D-4498-B343-8F8260E1127C",
                },
                new Property
                {
                    Id = Guid.NewGuid(),
                    Title = "Majestic Mansion in Abuja",
                    Description = "Step into this majestic mansion with 7 bedrooms, 6 bathrooms, and exquisite architecture. Located in the diplomatic zone of Abuja, this property offers a grand entrance, lush gardens, and a private cinema room.",
                    Address = "7 Diplomat Avenue, Abuja",
                    Structure = PropertyType.Mansion,
                    Privacy = PrivacyType.EntirePlace,
                    Bedrooms = 7,
                    Bathrooms = 6,
                    PropertyAmenities = "Kitchen, Tv, Wifi, AirConditioning, Cinema, Garden",
                    Price = 10000000.00m, // Yearly rent in NGN
                    Duration = RentInterval.Yearly,
                    CoverPhotoURL = "https://example.com/property7-cover.jpg",
                    PropertyPhotosURLs = "https://example.com/property7-photo1.jpg,https://example.com/property7-photo2.jpg",
                    CreatedDate = DateTime.Now,
                    UserId = "826E0C43-871D-4498-B343-8F8260E1127C",
                },
                new Property
                {
                    Id = Guid.NewGuid(),
                    Title = "Modern Maisonette in Port Harcourt",
                    Description = "Discover modern living in this beautiful maisonette with 3 bedrooms, 2 bathrooms, and a contemporary design. Located in Port Harcourt's upscale neighborhood, this property offers a stylish kitchen, a private garden, and easy access to local amenities.",
                    Address = "8 Riverside Street, Port Harcourt",
                    Structure = PropertyType.Maisonette,
                    Privacy = PrivacyType.EntirePlace,
                    Bedrooms = 3,
                    Bathrooms = 2,
                    PropertyAmenities = "Kitchen, Tv, Wifi, AirConditioning, Garden",
                    Price = 2800000.00m, // Monthly rent in NGN
                    Duration = RentInterval.Yearly,
                    CoverPhotoURL = "https://example.com/property8-cover.jpg",
                    PropertyPhotosURLs = "https://example.com/property8-photo1.jpg,https://example.com/property8-photo2.jpg",
                    CreatedDate = DateTime.Now,
                    UserId = "91F6AFD4-8D50-40B1-B09E-E799723E952D",
                },
                new Property
                {
                    Id = Guid.NewGuid(),
                    Title = "Riverside Mansion in Port Harcourt",
                    Description = "Experience riverside living in this grand mansion with 6 bedrooms, 5 bathrooms, and panoramic views of the river. This mansion boasts a private dock, a spacious dining hall, and beautifully landscaped gardens.",
                    Address = "9 Riverside Drive, Port Harcourt",
                    Structure = PropertyType.Mansion,
                    Privacy = PrivacyType.EntirePlace,
                    Bedrooms = 6,
                    Bathrooms = 5,
                    PropertyAmenities = "Kitchen, Tv, Wifi, AirConditioning, PrivateDock, Garden",
                    Price = 7500000.00m, // Monthly rent in NGN
                    Duration = RentInterval.Yearly,
                    CoverPhotoURL = "https://example.com/property9-cover.jpg",
                    PropertyPhotosURLs = "https://example.com/property9-photo1.jpg,https://example.com/property9-photo2.jpg",
                    CreatedDate = DateTime.Now,
                    UserId = "91F6AFD4-8D50-40B1-B09E-E799723E952D",
                },
                new Property
                {
                    Id = Guid.NewGuid(),
                    Title = "Elegant Terrace Duplex in Lekki",
                    Description = "Discover elegance in this terrace duplex with 3 bedrooms, 2 bathrooms, and modern design. Located in Lekki's upscale neighborhood, this property offers a well-appointed kitchen, a cozy living room, and a private courtyard.",
                    Address = "10 Lekki Gardens, Lekki",
                    Structure = PropertyType.TerraceDuplex,
                    Privacy = PrivacyType.EntirePlace,
                    Bedrooms = 3,
                    Bathrooms = 2,
                    PropertyAmenities = "Kitchen, Tv, Wifi, AirConditioning, PrivateCourtyard",
                    Price = 300000.00m, // Monthly rent in NGN
                    Duration = RentInterval.Monthly,
                    CoverPhotoURL = "https://example.com/property10-cover.jpg",
                    PropertyPhotosURLs = "https://example.com/property10-photo1.jpg,https://example.com/property10-photo2.jpg",
                    CreatedDate = DateTime.Now,
                    UserId = "3F373D01-67C5-4FBC-92BB-3C84117CAE7B",
                },
                new Property
                {
                    Id = Guid.NewGuid(),
                    Title = "Seaside Villa in Lagos",
                    Description = "Escape to this seaside villa with 4 bedrooms, 3 bathrooms, and direct access to the beach. This villa offers a fully equipped kitchen, a private swimming pool, and breathtaking sunset views over the ocean.",
                    Address = "11 Beachfront Lane, Lagos",
                    Structure = PropertyType.Villa,
                    Privacy = PrivacyType.EntirePlace,
                    Bedrooms = 4,
                    Bathrooms = 3,
                    PropertyAmenities = "Kitchen, Tv, Wifi, AirConditioning, PrivatePool, BeachAccess",
                    Price = 5500000.00m, // Monthly rent in NGN
                    Duration = RentInterval.Yearly,
                    CoverPhotoURL = "https://example.com/property11-cover.jpg",
                    PropertyPhotosURLs = "https://example.com/property11-photo1.jpg,https://example.com/property11-photo2.jpg",
                    CreatedDate = DateTime.Now,
                    UserId = "3F373D01-67C5-4FBC-92BB-3C84117CAE7B",
                },
                new Property
                {
                    Id = Guid.NewGuid(),
                    Title = "Eco-Friendly Cottage in Enugu",
                    Description = "Experience eco-friendly living in this cozy cottage with 2 bedrooms, 1 bathroom, and sustainable features. Located in the serene hills of Enugu, this cottage offers a vegetable garden, solar & inverter, and a tranquil atmosphere.",
                    Address = "12 Green Hills Road, Enugu",
                    Structure = PropertyType.Cottage,
                    Privacy = PrivacyType.EntirePlace,
                    Bedrooms = 2,
                    Bathrooms = 1,
                    PropertyAmenities = "Kitchen, Tv, Wifi, SolarAndInverter, VegetableGarden",
                    Price = 1800000.00m, // Monthly rent in NGN
                    Duration = RentInterval.Monthly,
                    CoverPhotoURL = "https://example.com/property12-cover.jpg",
                    PropertyPhotosURLs = "https://example.com/property12-photo1.jpg,https://example.com/property12-photo2.jpg",
                    CreatedDate = DateTime.Now,
                    UserId = "3F373D01-67C5-4FBC-92BB-3C84117CAE7B",
                },
                new Property
                {
                    Id = Guid.NewGuid(),
                    Title = "Historic Villa in Abeokuta",
                    Description = "Step into history in this historic villa with 6 bedrooms, 4 bathrooms, and antique charm. Located in the heart of Abeokuta, this villa features original architecture, a library, and a spacious courtyard.",
                    Address = "13 Heritage Street, Abeokuta",
                    Structure = PropertyType.Villa,
                    Privacy = PrivacyType.EntirePlace,
                    Bedrooms = 6,
                    Bathrooms = 4,
                    PropertyAmenities = "Kitchen, Tv, Wifi, Library, Courtyard",
                    Price = 420000.00m, // Monthly rent in NGN
                    Duration = RentInterval.Monthly,
                    CoverPhotoURL = "https://example.com/property13-cover.jpg",
                    PropertyPhotosURLs = "https://example.com/property13-photo1.jpg,https://example.com/property13-photo2.jpg",
                    CreatedDate = DateTime.Now,
                    UserId = "0C2E622E-49D1-4A80-AB68-A5AB3A213877",
                },
                new Property
                {
                    Id = Guid.NewGuid(),
                    Title = "Secluded Cabin in Ondo Forest",
                    Description = "Escape to nature in this secluded cabin with 1 bedroom, 1 bathroom, and a tranquil forest setting. Located deep in the Ondo Forest, this cabin offers a fireplace, hiking trails, and a true getaway from the city.",
                    Address = "14 Forest Retreat, Ondo",
                    Structure = PropertyType.Cabin,
                    Privacy = PrivacyType.EntirePlace,
                    Bedrooms = 1,
                    Bathrooms = 1,
                    PropertyAmenities = "Kitchen, Fireplace, HikingTrails",
                    Price = 120000.00m, // Monthly rent in NGN
                    Duration = RentInterval.Monthly,
                    CoverPhotoURL = "https://example.com/property14-cover.jpg",
                    PropertyPhotosURLs = "https://example.com/property14-photo1.jpg,https://example.com/property14-photo2.jpg",
                    CreatedDate = DateTime.Now,
                    UserId = "0C2E622E-49D1-4A80-AB68-A5AB3A213877",
                },
                new Property
                {
                    Id = Guid.NewGuid(),
                    Title = "Luxury Beachfront Villa in Lagos",
                    Description = "Indulge in luxury at this beachfront villa with 4 bedrooms, 3 bathrooms, and direct access to the ocean. This villa offers a private chef, infinity pool, and stunning sunset views over the Atlantic.",
                    Address = "15 Oceanview Road, Lagos",
                    Structure = PropertyType.Villa,
                    Privacy = PrivacyType.EntirePlace,
                    Bedrooms = 4,
                    Bathrooms = 3,
                    PropertyAmenities = "Kitchen, Tv, Wifi, AirConditioning, Pool, PrivateChef",
                    Price = 100000.00m, // Weekly rent in NGN
                    Duration = RentInterval.Weekly,
                    CoverPhotoURL = "https://example.com/property15-cover.jpg",
                    PropertyPhotosURLs = "https://example.com/property15-photo1.jpg,https://example.com/property15-photo2.jpg",
                    CreatedDate = DateTime.Now,
                    UserId = "0C2E622E-49D1-4A80-AB68-A5AB3A213877",
                },
                new Property
                {
                    Id = Guid.NewGuid(),
                    Title = "Modern Waterfront Apartment in Lagos Island",
                    Description = "Enjoy modern living in this waterfront apartment with 2 bedrooms, 2 bathrooms, and stunning views of Lagos Island. This apartment features a fully equipped kitchen, fitness center, and 24/7 concierge service.",
                    Address = "16 Marina View, Lagos",
                    Structure = PropertyType.Apartment,
                    Privacy = PrivacyType.EntirePlace,
                    Bedrooms = 2,
                    Bathrooms = 2,
                    PropertyAmenities = "Kitchen, Tv, Wifi, AirConditioning, FitnessCenter, Concierge",
                    Price = 45000.00m, // Monthly rent in NGN
                    Duration = RentInterval.Weekly,
                    CoverPhotoURL = "https://example.com/property16-cover.jpg",
                    PropertyPhotosURLs = "https://example.com/property16-photo1.jpg,https://example.com/property16-photo2.jpg",
                    CreatedDate = DateTime.Now,
                    UserId = "0C2E622E-49D1-4A80-AB68-A5AB3A213877",
                },
                new Property
                {
                    Id = Guid.NewGuid(),
                    Title = "Luxurious Lagos Penthouse with Skyline Views",
                    Description = "Live in luxury at this Lagos penthouse with 3 bedrooms, 2 bathrooms, and panoramic skyline views. This penthouse offers a rooftop terrace, spa, and private elevator access.",
                    Address = "17 Skyline Towers, Lagos",
                    Structure = PropertyType.PentHouse,
                    Privacy = PrivacyType.EntirePlace,
                    Bedrooms = 3,
                    Bathrooms = 2,
                    PropertyAmenities = "Kitchen, Tv, Wifi, AirConditioning, RooftopTerrace, Spa",
                    Price = 5500000.00m, // Monthly rent in NGN
                    Duration = RentInterval.Yearly,
                    CoverPhotoURL = "https://example.com/property17-cover.jpg",
                    PropertyPhotosURLs = "https://example.com/property17-photo1.jpg,https://example.com/property17-photo2.jpg",
                    CreatedDate = DateTime.Now,
                    UserId = "0C2E622E-49D1-4A80-AB68-A5AB3A213877",
                },
                new Property
                {
                    Id = Guid.NewGuid(),
                    Title = "Contemporary Lagos Loft with City Views",
                    Description = "Experience urban living in this contemporary loft with 1 bedroom, 1 bathroom, and breathtaking city views. This loft offers an open-concept design, modern furnishings, and easy access to Lagos nightlife.",
                    Address = "18 Cityscape Lane, Lagos",
                    Structure = PropertyType.Apartment,
                    Privacy = PrivacyType.PrivateRoom,
                    Bedrooms = 1,
                    Bathrooms = 1,
                    PropertyAmenities = "Kitchen, Tv, Wifi, AirConditioning",
                    Price = 100000.00m, // Monthly rent in NGN
                    Duration = RentInterval.Monthly,
                    CoverPhotoURL = "https://example.com/property18-cover.jpg",
                    PropertyPhotosURLs = "https://example.com/property18-photo1.jpg,https://example.com/property18-photo2.jpg",
                    CreatedDate = DateTime.Now,
                    UserId = "0C2E622E-49D1-4A80-AB68-A5AB3A213877",
                },
                new Property
                {
                    Id = Guid.NewGuid(),
                    Title = "Serene Waterfront Retreat in Lagos",
                    Description = "Escape to this serene waterfront retreat with 1 bedroom, 1 bathroom, and direct access to the lagoon. This retreat features a private boat dock, lush gardens, and a peaceful atmosphere.",
                    Address = "19 Lagoonview Drive, Lagos",
                    Structure = PropertyType.GuestHouse,
                    Privacy = PrivacyType.PrivateRoom,
                    Bedrooms = 1,
                    Bathrooms = 1,
                    PropertyAmenities = "Kitchen, Tv, Wifi, LagoonAccess, BoatDock, Gardens",
                    Price = 200000.00m, // Monthly rent in NGN
                    Duration = RentInterval.Monthly,
                    CoverPhotoURL = "https://example.com/property19-cover.jpg",
                    PropertyPhotosURLs = "https://example.com/property19-photo1.jpg,https://example.com/property19-photo2.jpg",
                    CreatedDate = DateTime.Now,
                    UserId = "0C2E622E-49D1-4A80-AB68-A5AB3A213877",
                },
                new Property
                {
                    Id = Guid.NewGuid(),
                    Title = "Modern Apartment in Victoria Island",
                    Description = "Live in style at this modern apartment with 2 bedrooms, 2 bathrooms, and city views in Victoria Island. This apartment offers sleek design, a fitness center, and proximity to top restaurants.",
                    Address = "20 Luxury Avenue, Victoria Island, Lagos",
                    Structure = PropertyType.Apartment,
                    Privacy = PrivacyType.EntirePlace,
                    Bedrooms = 2,
                    Bathrooms = 2,
                    PropertyAmenities = "Kitchen, Tv, Wifi, AirConditioning, FitnessCenter, DiningOptions",
                    Price = 450000.00m, // Monthly rent in NGN
                    Duration = RentInterval.Monthly,
                    CoverPhotoURL = "https://example.com/property20-cover.jpg",
                    PropertyPhotosURLs = "https://example.com/property20-photo1.jpg,https://example.com/property20-photo2.jpg",
                    CreatedDate = DateTime.Now,
                    UserId = "0C2E622E-49D1-4A80-AB68-A5AB3A213877",
                }
            );
        }
    }
}
