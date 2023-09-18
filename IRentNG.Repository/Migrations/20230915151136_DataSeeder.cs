using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IRentNG.Repository.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72914964-9e49-496b-8848-2a2854e77901");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "921b4f4e-4f7e-43b2-bce1-a43948cad900");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e656bf26-5fbc-46c1-951b-1b47bd000391");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "579cb2f2-5256-4014-8279-08f527b7f302");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a5c9a15-7f19-46ff-9e1d-62d617126006");

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: new Guid("1b5e8863-906d-4a9d-b4b3-10c6100b6fc9"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: new Guid("afe12c0a-880e-4559-9725-fdd49d06f91c"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "00ab5334-1317-4aa1-9c9c-59d834f812da", null, "Landlord", "LANDLORD" },
                    { "0c565282-7fac-4429-8cfe-0268259bb6c0", null, "Administrator", "ADMINISTRATOR" },
                    { "d0aeabaf-ebaf-4208-9fff-6e2d1c2f04f8", null, "Tenant", "TENANT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PermanentAddress", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0C2E622E-49D1-4A80-AB68-A5AB3A213877", 0, "160001d6-ba8e-4bb4-9702-0b4aa6df5946", new DateTime(2023, 9, 15, 16, 11, 35, 927, DateTimeKind.Local).AddTicks(6140), "landlord5@example.com", false, "David Rental", false, null, null, null, "AQAAAAIAAYagAAAAEGuHk0eTtYm0MM74vYEQaddwELLXEKB93pKzf84v9bgvyP/Pt9aIh8ttk35+F+TBIw==", "234 Property Place, Lagos", "+5678901234", false, "https://example.com/profile5.jpg", "6d09f82a-3944-409a-8db5-040f12015e95", false, "landlord5@example.com" },
                    { "3F373D01-67C5-4FBC-92BB-3C84117CAE7B", 0, "4f320083-8adc-4ac3-a896-231016d38569", new DateTime(2023, 9, 15, 16, 11, 35, 786, DateTimeKind.Local).AddTicks(44), "landlord4@example.com", false, "Laura Landlord", false, null, null, null, "AQAAAAIAAYagAAAAELGOaq6cV+AJUL3FH+jrPp7I0IxEqZYRmh5RjF5HNarYp1Wj02asocAVAYkWkEvxMg==", "101 Landlord Avenue, Abuja", "+4567890123", false, "https://example.com/profile4.jpg", "1c6df5fa-e0be-4430-9ad3-0f0a68315473", false, "landlord4@example.com" },
                    { "579CB2F2-5256-4014-8279-08F527B7F302", 0, "461c2ea2-3c96-4584-9e4d-f569f38f6d22", new DateTime(2023, 9, 15, 16, 11, 34, 813, DateTimeKind.Local).AddTicks(1278), "admin@example.com", true, "Josh Admin", false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAENPas5qEABfP9E6h8WcTA8vj1byEMENlzDyKBN+GVcpqi6jbQM7owZPUERFvUMljDg==", "123 Main Street", null, false, "https://example.com/user1.jpg", "998c7b63-f5f1-4719-9922-33591349e080", false, "admin@example.com" },
                    { "6A5C9A15-7F19-46FF-9E1D-62D617126006", 0, "dc4c5044-46d8-496a-b997-4e4f4de5c7f3", new DateTime(2023, 9, 15, 16, 11, 35, 29, DateTimeKind.Local).AddTicks(5274), "landlord@example.com", true, "Josh Landlord", false, null, "LANDLORD@EXAMPLE.COM", "LANDLORD@EXAMPLE.COM", "AQAAAAIAAYagAAAAENy+rN7CXNcB3kTNvQfjQz6CLTiHyyw2QmrJNvh7kcsU1sfF7cjm+UPZl6q/3dGAQw==", "456 Elm Street", "+2349025621988", false, "https://example.com/user2.jpg", "56aeedf1-5a3c-49bf-9b67-ca41193f63bd", false, "landlord@example.com" },
                    { "826E0C43-871D-4498-B343-8F8260E1127C", 0, "3e311e15-8454-4eb2-8166-fec42c9f6d0c", new DateTime(2023, 9, 15, 16, 11, 35, 414, DateTimeKind.Local).AddTicks(4446), "landlord2@example.com", false, "Jane PropertyOwner", false, null, null, null, "AQAAAAIAAYagAAAAEMHafzqe6Wrt4puAyCbfthPhSw3IAKRVk6MvovrerbvKvq+skq0q4uNOGofjhdjOEg==", "456 Landlord Street, Abuja", "+2345678901", false, "https://example.com/profile2.jpg", "d52808e8-8ff3-4694-893f-61a9d07b038a", false, "landlord2@example.com" },
                    { "91F6AFD4-8D50-40B1-B09E-E799723E952D", 0, "1662c153-ccff-483f-976c-49e9688f60ad", new DateTime(2023, 9, 15, 16, 11, 35, 603, DateTimeKind.Local).AddTicks(9509), "landlord3@example.com", false, "Chris RealEstate", false, null, null, null, "AQAAAAIAAYagAAAAEIBb3bbgiee1+ktmocLpmBcG4GepN97XlSvclFwEKQm340qcP5cNuTS96yqwyV/uKw==", "789 Rental Road, Lagos", "+3456789012", false, "https://example.com/profile3.jpg", "e248bd7c-3eed-437a-bb3d-76fe076ba166", false, "landlord3@example.com" },
                    { "9FE6F8FB-CE97-4DAE-AE02-0B3AC6B114FA", 0, "a3f376ad-33b4-4a11-b218-8e9e7c6c2f3c", new DateTime(2023, 9, 15, 16, 11, 35, 224, DateTimeKind.Local).AddTicks(9044), "landlord1@example.com", false, "John Landlord", false, null, null, null, "AQAAAAIAAYagAAAAEF1he9+OqmdIfH4Sdf3B5HckO8Wii7rrQ1kf7OCS+63L1vWCuoS2C7Onr7qYMwnXGw==", "123 Landlord Lane, Lagos", "+1234567890", false, "https://example.com/profile1.jpg", "d89e6ca3-0f8d-4986-88b8-0055fa523ff6", false, "landlord1@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "PropertyId", "Address", "Bathrooms", "Bedrooms", "CoverPhotoURL", "CreatedDate", "Description", "Duration", "Price", "Privacy", "PropertyAmenities", "PropertyPhotosURLs", "Structure", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("02088ebe-9ecd-4008-ad77-ee1d292eeb8f"), "8 Riverside Street, Port Harcourt", 2, 3, "https://example.com/property8-cover.jpg", new DateTime(2023, 9, 15, 16, 11, 35, 927, DateTimeKind.Local).AddTicks(8677), "Discover modern living in this beautiful maisonette with 3 bedrooms, 2 bathrooms, and a contemporary design. Located in Port Harcourt's upscale neighborhood, this property offers a stylish kitchen, a private garden, and easy access to local amenities.", 1, 2800000.00m, 1, "Kitchen, Tv, Wifi, AirConditioning, Garden", "https://example.com/property8-photo1.jpg,https://example.com/property8-photo2.jpg", 7, "Modern Maisonette in Port Harcourt", "91F6AFD4-8D50-40B1-B09E-E799723E952D" },
                    { new Guid("042a5756-48fd-4d8a-b99c-fd31cf773ff8"), "12 Green Hills Road, Enugu", 1, 2, "https://example.com/property12-cover.jpg", new DateTime(2023, 9, 15, 16, 11, 35, 927, DateTimeKind.Local).AddTicks(8730), "Experience eco-friendly living in this cozy cottage with 2 bedrooms, 1 bathroom, and sustainable features. Located in the serene hills of Enugu, this cottage offers a vegetable garden, solar & inverter, and a tranquil atmosphere.", 2, 1800000.00m, 1, "Kitchen, Tv, Wifi, SolarAndInverter, VegetableGarden", "https://example.com/property12-photo1.jpg,https://example.com/property12-photo2.jpg", 11, "Eco-Friendly Cottage in Enugu", "3F373D01-67C5-4FBC-92BB-3C84117CAE7B" },
                    { new Guid("07b80f7d-0b4e-4067-88c9-cb3e9cf5d2f0"), "18 Cityscape Lane, Lagos", 1, 1, "https://example.com/property18-cover.jpg", new DateTime(2023, 9, 15, 16, 11, 35, 927, DateTimeKind.Local).AddTicks(8800), "Experience urban living in this contemporary loft with 1 bedroom, 1 bathroom, and breathtaking city views. This loft offers an open-concept design, modern furnishings, and easy access to Lagos nightlife.", 2, 100000.00m, 2, "Kitchen, Tv, Wifi, AirConditioning", "https://example.com/property18-photo1.jpg,https://example.com/property18-photo2.jpg", 1, "Contemporary Lagos Loft with City Views", "0C2E622E-49D1-4A80-AB68-A5AB3A213877" },
                    { new Guid("1057a090-8277-4351-b135-b119ab61d24e"), "12 Garki, Abuja", 4, 5, "https://example.com/property2-cover.jpg", new DateTime(2023, 9, 15, 16, 11, 35, 927, DateTimeKind.Local).AddTicks(8570), "Indulge in luxury at this stunning villa in Abuja. This spacious five-bedroom villa features a private pool, lush gardens, and a fully equipped kitchen. Perfect for special events or a relaxing getaway.", 1, 5000000.00m, 1, "Kitchen, Tv, Wifi, AirConditioning, Pool, BBQGrill", "https://example.com/property2-photo1.jpg,https://example.com/property2-photo2.jpg", 9, "Luxury Villa in Abuja", "9FE6F8FB-CE97-4DAE-AE02-0B3AC6B114FA" },
                    { new Guid("11de0802-2b14-4e24-8e9c-4f0cc0f56d06"), "19 Lagoonview Drive, Lagos", 1, 1, "https://example.com/property19-cover.jpg", new DateTime(2023, 9, 15, 16, 11, 35, 927, DateTimeKind.Local).AddTicks(8809), "Escape to this serene waterfront retreat with 1 bedroom, 1 bathroom, and direct access to the lagoon. This retreat features a private boat dock, lush gardens, and a peaceful atmosphere.", 2, 200000.00m, 2, "Kitchen, Tv, Wifi, LagoonAccess, BoatDock, Gardens", "https://example.com/property19-photo1.jpg,https://example.com/property19-photo2.jpg", 3, "Serene Waterfront Retreat in Lagos", "0C2E622E-49D1-4A80-AB68-A5AB3A213877" },
                    { new Guid("22670d16-8f81-4faa-be44-319c391b8dd9"), "20 Luxury Avenue, Victoria Island, Lagos", 2, 2, "https://example.com/property20-cover.jpg", new DateTime(2023, 9, 15, 16, 11, 35, 927, DateTimeKind.Local).AddTicks(8818), "Live in style at this modern apartment with 2 bedrooms, 2 bathrooms, and city views in Victoria Island. This apartment offers sleek design, a fitness center, and proximity to top restaurants.", 2, 450000.00m, 1, "Kitchen, Tv, Wifi, AirConditioning, FitnessCenter, DiningOptions", "https://example.com/property20-photo1.jpg,https://example.com/property20-photo2.jpg", 1, "Modern Apartment in Victoria Island", "0C2E622E-49D1-4A80-AB68-A5AB3A213877" },
                    { new Guid("250908e6-99fc-48e9-a335-f43fcbc1fa6e"), "9 Riverside Drive, Port Harcourt", 5, 6, "https://example.com/property9-cover.jpg", new DateTime(2023, 9, 15, 16, 11, 35, 927, DateTimeKind.Local).AddTicks(8688), "Experience riverside living in this grand mansion with 6 bedrooms, 5 bathrooms, and panoramic views of the river. This mansion boasts a private dock, a spacious dining hall, and beautifully landscaped gardens.", 1, 7500000.00m, 1, "Kitchen, Tv, Wifi, AirConditioning, PrivateDock, Garden", "https://example.com/property9-photo1.jpg,https://example.com/property9-photo2.jpg", 9, "Riverside Mansion in Port Harcourt", "91F6AFD4-8D50-40B1-B09E-E799723E952D" },
                    { new Guid("2a8c28f3-d0e3-42fe-b87e-359a1bc13e3c"), "4 Lekki Gardens, Lekki", 3, 4, "https://example.com/property4-cover.jpg", new DateTime(2023, 9, 15, 16, 11, 35, 927, DateTimeKind.Local).AddTicks(8593), "A modern terrace duplex with 4 bedrooms, 3 bathrooms, and contemporary design. This property is situated in the trendy Lekki neighborhood and offers spacious rooms, a sleek kitchen, and a rooftop terrace with stunning views.", 2, 600000.00m, 1, "Kitchen, Tv, Wifi, AirConditioning, RooftopTerrace", "https://example.com/property4-photo1.jpg,https://example.com/property4-photo2.jpg", 6, "Modern Terrace Duplex in Lekki", "9FE6F8FB-CE97-4DAE-AE02-0B3AC6B114FA" },
                    { new Guid("429a1dc2-5f02-4a02-bc0a-57fcc16b433a"), "17 Skyline Towers, Lagos", 2, 3, "https://example.com/property17-cover.jpg", new DateTime(2023, 9, 15, 16, 11, 35, 927, DateTimeKind.Local).AddTicks(8789), "Live in luxury at this Lagos penthouse with 3 bedrooms, 2 bathrooms, and panoramic skyline views. This penthouse offers a rooftop terrace, spa, and private elevator access.", 1, 5500000.00m, 1, "Kitchen, Tv, Wifi, AirConditioning, RooftopTerrace, Spa", "https://example.com/property17-photo1.jpg,https://example.com/property17-photo2.jpg", 8, "Luxurious Lagos Penthouse with Skyline Views", "0C2E622E-49D1-4A80-AB68-A5AB3A213877" },
                    { new Guid("43dfef41-4c65-4cc3-ba67-aba865cda88f"), "6 Marina Drive, Lagos", 4, 5, "https://example.com/property6-cover.jpg", new DateTime(2023, 9, 15, 16, 11, 35, 927, DateTimeKind.Local).AddTicks(8653), "Experience luxury living in this spacious penthouse with 5 bedrooms, 4 bathrooms, and breathtaking views of Lagos. This penthouse features a gourmet kitchen, private elevator access, and access to a rooftop pool and lounge.", 2, 1000000.00m, 1, "Kitchen, Tv, Wifi, AirConditioning, RooftopPool", "https://example.com/property6-photo1.jpg,https://example.com/property6-photo2.jpg", 8, "Luxurious Penthouse in Lagos", "826E0C43-871D-4498-B343-8F8260E1127C" },
                    { new Guid("50f9a624-c6b0-4379-878a-e33cdb54a59c"), "14 Forest Retreat, Ondo", 1, 1, "https://example.com/property14-cover.jpg", new DateTime(2023, 9, 15, 16, 11, 35, 927, DateTimeKind.Local).AddTicks(8756), "Escape to nature in this secluded cabin with 1 bedroom, 1 bathroom, and a tranquil forest setting. Located deep in the Ondo Forest, this cabin offers a fireplace, hiking trails, and a true getaway from the city.", 2, 120000.00m, 1, "Kitchen, Fireplace, HikingTrails", "https://example.com/property14-photo1.jpg,https://example.com/property14-photo2.jpg", 12, "Secluded Cabin in Ondo Forest", "0C2E622E-49D1-4A80-AB68-A5AB3A213877" },
                    { new Guid("5560f929-f2cd-44b5-bd84-4d39abca0595"), "3 Ocean View Drive, Victoria Island", 2, 3, "https://example.com/property3-cover.jpg", new DateTime(2023, 9, 15, 16, 11, 35, 927, DateTimeKind.Local).AddTicks(8582), "A spacious apartment with 3 bedrooms, 2 bathrooms, and a stunning view of the ocean. Located in the upscale Victoria Island neighborhood, this property offers luxury living, a fully equipped kitchen, and access to a private pool and gym.", 1, 3500000.00m, 1, "Kitchen, Tv, Wifi, AirConditioning, Pool, Gym", "https://example.com/property3-photo1.jpg,https://example.com/property3-photo2.jpg", 1, "Spacious Apartment in Victoria Island", "9FE6F8FB-CE97-4DAE-AE02-0B3AC6B114FA" },
                    { new Guid("5fd0c9ec-9c94-43e6-80a4-f3007105e654"), "10 Lekki Gardens, Lekki", 2, 3, "https://example.com/property10-cover.jpg", new DateTime(2023, 9, 15, 16, 11, 35, 927, DateTimeKind.Local).AddTicks(8711), "Discover elegance in this terrace duplex with 3 bedrooms, 2 bathrooms, and modern design. Located in Lekki's upscale neighborhood, this property offers a well-appointed kitchen, a cozy living room, and a private courtyard.", 2, 300000.00m, 1, "Kitchen, Tv, Wifi, AirConditioning, PrivateCourtyard", "https://example.com/property10-photo1.jpg,https://example.com/property10-photo2.jpg", 6, "Elegant Terrace Duplex in Lekki", "3F373D01-67C5-4FBC-92BB-3C84117CAE7B" },
                    { new Guid("62620db4-6119-4dc6-951a-199c3ebb2681"), "11 Beachfront Lane, Lagos", 3, 4, "https://example.com/property11-cover.jpg", new DateTime(2023, 9, 15, 16, 11, 35, 927, DateTimeKind.Local).AddTicks(8720), "Escape to this seaside villa with 4 bedrooms, 3 bathrooms, and direct access to the beach. This villa offers a fully equipped kitchen, a private swimming pool, and breathtaking sunset views over the ocean.", 1, 5500000.00m, 1, "Kitchen, Tv, Wifi, AirConditioning, PrivatePool, BeachAccess", "https://example.com/property11-photo1.jpg,https://example.com/property11-photo2.jpg", 10, "Seaside Villa in Lagos", "3F373D01-67C5-4FBC-92BB-3C84117CAE7B" },
                    { new Guid("747b4f4b-f91e-444c-ac8f-e5ccc9ff7ff4"), "16 Marina View, Lagos", 2, 2, "https://example.com/property16-cover.jpg", new DateTime(2023, 9, 15, 16, 11, 35, 927, DateTimeKind.Local).AddTicks(8780), "Enjoy modern living in this waterfront apartment with 2 bedrooms, 2 bathrooms, and stunning views of Lagos Island. This apartment features a fully equipped kitchen, fitness center, and 24/7 concierge service.", 3, 45000.00m, 1, "Kitchen, Tv, Wifi, AirConditioning, FitnessCenter, Concierge", "https://example.com/property16-photo1.jpg,https://example.com/property16-photo2.jpg", 1, "Modern Waterfront Apartment in Lagos Island", "0C2E622E-49D1-4A80-AB68-A5AB3A213877" },
                    { new Guid("84ebbb16-57bc-4dbf-8f91-391f48113ca2"), "1 Victoria Island, Lagos", 2, 3, "https://example.com/property1-cover.jpg", new DateTime(2023, 9, 15, 16, 11, 35, 927, DateTimeKind.Local).AddTicks(8554), "Experience luxury living in this spacious apartment located in the heart of Lagos Island. This stunning three-bedroom apartment features a modern kitchen, beautiful city views, and access to top-notch amenities.", 1, 2500000.00m, 1, "Kitchen, Wifi, AirConditioning, FreeParkingOnPremises", "https://example.com/property1-photo1.jpg,https://example.com/property1-photo2.jpg", 1, "Luxury Apartment in Lagos Island", "9FE6F8FB-CE97-4DAE-AE02-0B3AC6B114FA" },
                    { new Guid("b3afbe97-9551-487e-991f-13040a95e020"), "13 Heritage Street, Abeokuta", 4, 6, "https://example.com/property13-cover.jpg", new DateTime(2023, 9, 15, 16, 11, 35, 927, DateTimeKind.Local).AddTicks(8739), "Step into history in this historic villa with 6 bedrooms, 4 bathrooms, and antique charm. Located in the heart of Abeokuta, this villa features original architecture, a library, and a spacious courtyard.", 2, 420000.00m, 1, "Kitchen, Tv, Wifi, Library, Courtyard", "https://example.com/property13-photo1.jpg,https://example.com/property13-photo2.jpg", 10, "Historic Villa in Abeokuta", "0C2E622E-49D1-4A80-AB68-A5AB3A213877" },
                    { new Guid("d40e1a94-203f-4f56-8450-531906fe43d0"), "5 Calabar Lane, Calabar", 6, 6, "https://example.com/property5-cover.jpg", new DateTime(2023, 9, 15, 16, 11, 35, 927, DateTimeKind.Local).AddTicks(8624), "A charming guest house with 6 cozy rooms, each with its own bathroom. This guest house is located in the beautiful city of Calabar and offers a garden, free Wi-Fi, and a dedicated workspace. Perfect for travelers.", 2, 450000.00m, 1, "Kitchen, Tv, Wifi, DedicatedWorkspace, Garden", "https://example.com/property5-photo1.jpg,https://example.com/property5-photo2.jpg", 3, "Charming Guest House in Calabar", "826E0C43-871D-4498-B343-8F8260E1127C" },
                    { new Guid("d586440f-afc9-4f09-9624-70cb4c2e5c9d"), "7 Diplomat Avenue, Abuja", 6, 7, "https://example.com/property7-cover.jpg", new DateTime(2023, 9, 15, 16, 11, 35, 927, DateTimeKind.Local).AddTicks(8665), "Step into this majestic mansion with 7 bedrooms, 6 bathrooms, and exquisite architecture. Located in the diplomatic zone of Abuja, this property offers a grand entrance, lush gardens, and a private cinema room.", 1, 10000000.00m, 1, "Kitchen, Tv, Wifi, AirConditioning, Cinema, Garden", "https://example.com/property7-photo1.jpg,https://example.com/property7-photo2.jpg", 9, "Majestic Mansion in Abuja", "826E0C43-871D-4498-B343-8F8260E1127C" },
                    { new Guid("f0837def-f322-47ed-97e3-6a73ce806607"), "15 Oceanview Road, Lagos", 3, 4, "https://example.com/property15-cover.jpg", new DateTime(2023, 9, 15, 16, 11, 35, 927, DateTimeKind.Local).AddTicks(8768), "Indulge in luxury at this beachfront villa with 4 bedrooms, 3 bathrooms, and direct access to the ocean. This villa offers a private chef, infinity pool, and stunning sunset views over the Atlantic.", 3, 100000.00m, 1, "Kitchen, Tv, Wifi, AirConditioning, Pool, PrivateChef", "https://example.com/property15-photo1.jpg,https://example.com/property15-photo2.jpg", 10, "Luxury Beachfront Villa in Lagos", "0C2E622E-49D1-4A80-AB68-A5AB3A213877" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00ab5334-1317-4aa1-9c9c-59d834f812da");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c565282-7fac-4429-8cfe-0268259bb6c0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0aeabaf-ebaf-4208-9fff-6e2d1c2f04f8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "579CB2F2-5256-4014-8279-08F527B7F302");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6A5C9A15-7F19-46FF-9E1D-62D617126006");

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: new Guid("02088ebe-9ecd-4008-ad77-ee1d292eeb8f"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: new Guid("042a5756-48fd-4d8a-b99c-fd31cf773ff8"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: new Guid("07b80f7d-0b4e-4067-88c9-cb3e9cf5d2f0"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: new Guid("1057a090-8277-4351-b135-b119ab61d24e"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: new Guid("11de0802-2b14-4e24-8e9c-4f0cc0f56d06"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: new Guid("22670d16-8f81-4faa-be44-319c391b8dd9"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: new Guid("250908e6-99fc-48e9-a335-f43fcbc1fa6e"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: new Guid("2a8c28f3-d0e3-42fe-b87e-359a1bc13e3c"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: new Guid("429a1dc2-5f02-4a02-bc0a-57fcc16b433a"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: new Guid("43dfef41-4c65-4cc3-ba67-aba865cda88f"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: new Guid("50f9a624-c6b0-4379-878a-e33cdb54a59c"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: new Guid("5560f929-f2cd-44b5-bd84-4d39abca0595"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: new Guid("5fd0c9ec-9c94-43e6-80a4-f3007105e654"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: new Guid("62620db4-6119-4dc6-951a-199c3ebb2681"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: new Guid("747b4f4b-f91e-444c-ac8f-e5ccc9ff7ff4"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: new Guid("84ebbb16-57bc-4dbf-8f91-391f48113ca2"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: new Guid("b3afbe97-9551-487e-991f-13040a95e020"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: new Guid("d40e1a94-203f-4f56-8450-531906fe43d0"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: new Guid("d586440f-afc9-4f09-9624-70cb4c2e5c9d"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: new Guid("f0837def-f322-47ed-97e3-6a73ce806607"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0C2E622E-49D1-4A80-AB68-A5AB3A213877");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3F373D01-67C5-4FBC-92BB-3C84117CAE7B");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "826E0C43-871D-4498-B343-8F8260E1127C");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "91F6AFD4-8D50-40B1-B09E-E799723E952D");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9FE6F8FB-CE97-4DAE-AE02-0B3AC6B114FA");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "72914964-9e49-496b-8848-2a2854e77901", null, "Tenant", "TENANT" },
                    { "921b4f4e-4f7e-43b2-bce1-a43948cad900", null, "Administrator", "ADMINISTRATOR" },
                    { "e656bf26-5fbc-46c1-951b-1b47bd000391", null, "Landlord", "LANDLORD" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PermanentAddress", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "579cb2f2-5256-4014-8279-08f527b7f302", 0, "da235d60-84a5-4083-a578-5daf2e3e8a77", new DateTime(2023, 9, 15, 12, 10, 2, 289, DateTimeKind.Local).AddTicks(7018), "user1@example.com", true, "John Doe", false, null, "USER1@EXAMPLE.COM", "USER1@EXAMPLE.COM", "AQAAAAIAAYagAAAAENiLnymUkz9coSZiYS6GQq/UsTuJmlBO3NSoAmZJi1uKDLq/qOk4th9WEOyW93tAxA==", "123 Main Street", null, false, "https://example.com/user1.jpg", "a6f4ad3f-3a4c-4daf-b196-6569d5be3fbe", false, "user1@example.com" },
                    { "6a5c9a15-7f19-46ff-9e1d-62d617126006", 0, "32da9622-5c19-4de6-8624-6b252d7f4a81", new DateTime(2023, 9, 15, 12, 10, 2, 351, DateTimeKind.Local).AddTicks(9252), "user2@example.com", true, "Jane Smith", false, null, "USER2@EXAMPLE.COM", "USER2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOJfU60QsV5TegDnZ9NHexrTndJhVlwKMUsSf8pLh/L2e83NSjqTLql5YuwrYIeq6A==", "456 Elm Street", null, false, "https://example.com/user2.jpg", "13b2997e-cf4e-4ff5-a008-bbb5988f9e8c", false, "user2@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "PropertyId", "Address", "Bathrooms", "Bedrooms", "CoverPhotoURL", "CreatedDate", "Description", "Duration", "Price", "Privacy", "PropertyAmenities", "PropertyPhotosURLs", "Structure", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("1b5e8863-906d-4a9d-b4b3-10c6100b6fc9"), "123 Main Street", 1, 2, "https://example.com/coverphoto1.jpg", new DateTime(2023, 9, 15, 12, 10, 2, 454, DateTimeKind.Local).AddTicks(8820), "Description of Sample Property 1", 2, 100.00m, 1, null, null, 1, "Sample Property 1", "579CB2F2-5256-4014-8279-08F527B7F302" },
                    { new Guid("afe12c0a-880e-4559-9725-fdd49d06f91c"), "456 Elm Street", 1, 1, "https://example.com/coverphoto2.jpg", new DateTime(2023, 9, 15, 12, 10, 2, 454, DateTimeKind.Local).AddTicks(8909), "Description of Sample Property 2", 4, 50.00m, 2, null, null, 3, "Sample Property 2", "6A5C9A15-7F19-46FF-9E1D-62D617126006" }
                });
        }
    }
}
