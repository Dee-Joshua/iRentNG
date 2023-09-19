using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IRentNG.Repository.Migrations
{
    /// <inheritdoc />
    public partial class InitialDeploymentMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfilePicture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermanentAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateJoined = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    PropertyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Structure = table.Column<int>(type: "int", nullable: false),
                    Privacy = table.Column<int>(type: "int", nullable: false),
                    Bedrooms = table.Column<int>(type: "int", nullable: false),
                    Bathrooms = table.Column<int>(type: "int", nullable: false),
                    PropertyAmenities = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    CoverPhotoURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertyPhotosURLs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.PropertyId);
                    table.ForeignKey(
                        name: "FK_Properties_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "201f7411-6389-47e9-a8c7-d1aa12d23eca", null, "Administrator", "ADMINISTRATOR" },
                    { "c1ca115c-2ae9-4060-803f-118acc22ff6c", null, "Landlord", "LANDLORD" },
                    { "dd1107b9-28bc-4902-8c9e-2b47bbbc689b", null, "Tenant", "TENANT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PermanentAddress", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0C2E622E-49D1-4A80-AB68-A5AB3A213877", 0, "13f42fa0-2d8d-4862-9d93-d10b6b65c53c", new DateTime(2023, 9, 19, 12, 21, 37, 699, DateTimeKind.Local).AddTicks(1642), "landlord5@example.com", false, "David Rental", false, null, null, null, "AQAAAAIAAYagAAAAEAnxF79rXGmX2ntznvYV7IH/m6SRvkbXczqdyB2XsOWG81N77hOzVXSMjHiA0TTc6w==", "234 Property Place, Lagos", "+5678901234", false, "https://example.com/profile5.jpg", "46b64059-35f8-427a-93f6-1f60bd5ff484", false, "landlord5@example.com" },
                    { "3F373D01-67C5-4FBC-92BB-3C84117CAE7B", 0, "e359f8e3-0a7f-42be-a082-8f08468a12b9", new DateTime(2023, 9, 19, 12, 21, 37, 598, DateTimeKind.Local).AddTicks(4422), "landlord4@example.com", false, "Laura Landlord", false, null, null, null, "AQAAAAIAAYagAAAAEK4MF5abKkkwvk7qu8x5w1YfpsIgdHIPX2ZBBOA5WyBKnFLSshNf4MMehajqUVkpbA==", "101 Landlord Avenue, Abuja", "+4567890123", false, "https://example.com/profile4.jpg", "074f3eb9-632d-4343-94fd-9462b5f0ba46", false, "landlord4@example.com" },
                    { "579CB2F2-5256-4014-8279-08F527B7F302", 0, "8b2d106c-0e8d-457a-93a8-26ae29585f0f", new DateTime(2023, 9, 19, 12, 21, 37, 171, DateTimeKind.Local).AddTicks(6333), "admin@example.com", true, "Josh Admin", false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAECbadjovXsLz/jBuO97NEaIMrHyTDKMDJTeFOZKOFxq0abXrk08YSV10PR+8eELGPg==", "123 Main Street", null, false, "https://example.com/user1.jpg", "d01639df-9299-4f9f-9403-64a530dd5210", false, "admin@example.com" },
                    { "6A5C9A15-7F19-46FF-9E1D-62D617126006", 0, "f40da591-81c3-4fda-abb4-0db6714492c3", new DateTime(2023, 9, 19, 12, 21, 37, 255, DateTimeKind.Local).AddTicks(6367), "landlord@example.com", true, "Josh Landlord", false, null, "LANDLORD@EXAMPLE.COM", "LANDLORD@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHDz75zZ0uR4StToj6blMgGUUcMZbNkFctkVReKUktywen3W7O7ICwPnnYu05hU4eg==", "456 Elm Street", "+2349025621988", false, "https://example.com/user2.jpg", "ac8b3c4a-80f0-4096-a342-dbd2111d352d", false, "landlord@example.com" },
                    { "826E0C43-871D-4498-B343-8F8260E1127C", 0, "745282d5-a2be-462a-83b5-1e615cd0ffb7", new DateTime(2023, 9, 19, 12, 21, 37, 445, DateTimeKind.Local).AddTicks(5913), "landlord2@example.com", false, "Jane PropertyOwner", false, null, null, null, "AQAAAAIAAYagAAAAEFrr0LtGZesYFQlAuqdtuTCxfWXALB2Xw9Fp56sQvrHrR3Bhwj3xZBd2RDinecjRgw==", "456 Landlord Street, Abuja", "+2345678901", false, "https://example.com/profile2.jpg", "b253f740-c7c3-43bf-986c-5c53a8c293df", false, "landlord2@example.com" },
                    { "91F6AFD4-8D50-40B1-B09E-E799723E952D", 0, "e9f5949b-765d-44ac-ac46-231377c2eeb1", new DateTime(2023, 9, 19, 12, 21, 37, 527, DateTimeKind.Local).AddTicks(5521), "landlord3@example.com", false, "Chris RealEstate", false, null, null, null, "AQAAAAIAAYagAAAAEIDd3+Ti2Zb+r/mvjiMxjZ9ixo6s02U1ilJ8QPtR+LTDNX9pUNfCp1CQPfftqC2YdQ==", "789 Rental Road, Lagos", "+3456789012", false, "https://example.com/profile3.jpg", "ded1f424-62a8-46a1-a32c-b1a2b013318d", false, "landlord3@example.com" },
                    { "9FE6F8FB-CE97-4DAE-AE02-0B3AC6B114FA", 0, "88d791e7-018b-40a0-9bff-c29fb5545058", new DateTime(2023, 9, 19, 12, 21, 37, 376, DateTimeKind.Local).AddTicks(210), "landlord1@example.com", false, "John Landlord", false, null, null, null, "AQAAAAIAAYagAAAAEHG7it+KKlUSiwQMeIvFq5U5YCpU7t7M5XuOsWuJfude6jvaH/gJYwM7ja/ykm9WNA==", "123 Landlord Lane, Lagos", "+1234567890", false, "https://example.com/profile1.jpg", "6ffb26fe-1466-4250-94ed-c67783efbd4f", false, "landlord1@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "PropertyId", "Address", "Bathrooms", "Bedrooms", "CoverPhotoURL", "CreatedDate", "Description", "Duration", "Price", "Privacy", "PropertyAmenities", "PropertyPhotosURLs", "Structure", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("22e3c320-a239-48d9-a9e3-39c2c32f3b31"), "5 Calabar Lane, Calabar", 6, 6, "https://example.com/property5-cover.jpg", new DateTime(2023, 9, 19, 12, 21, 37, 699, DateTimeKind.Local).AddTicks(3486), "A charming guest house with 6 cozy rooms, each with its own bathroom. This guest house is located in the beautiful city of Calabar and offers a garden, free Wi-Fi, and a dedicated workspace. Perfect for travelers.", 2, 450000.00m, 1, "Kitchen, Tv, Wifi, DedicatedWorkspace, Garden", "https://example.com/property5-photo1.jpg,https://example.com/property5-photo2.jpg", 3, "Charming Guest House in Calabar", "826E0C43-871D-4498-B343-8F8260E1127C" },
                    { new Guid("2e8a1948-69cf-4f12-a5db-ef77226701f5"), "13 Heritage Street, Abeokuta", 4, 6, "https://example.com/property13-cover.jpg", new DateTime(2023, 9, 19, 12, 21, 37, 699, DateTimeKind.Local).AddTicks(3722), "Step into history in this historic villa with 6 bedrooms, 4 bathrooms, and antique charm. Located in the heart of Abeokuta, this villa features original architecture, a library, and a spacious courtyard.", 2, 420000.00m, 1, "Kitchen, Tv, Wifi, Library, Courtyard", "https://example.com/property13-photo1.jpg,https://example.com/property13-photo2.jpg", 10, "Historic Villa in Abeokuta", "0C2E622E-49D1-4A80-AB68-A5AB3A213877" },
                    { new Guid("2f383fe6-44c5-45bf-b777-7998464299b8"), "20 Luxury Avenue, Victoria Island, Lagos", 2, 2, "https://example.com/property20-cover.jpg", new DateTime(2023, 9, 19, 12, 21, 37, 699, DateTimeKind.Local).AddTicks(3766), "Live in style at this modern apartment with 2 bedrooms, 2 bathrooms, and city views in Victoria Island. This apartment offers sleek design, a fitness center, and proximity to top restaurants.", 2, 450000.00m, 1, "Kitchen, Tv, Wifi, AirConditioning, FitnessCenter, DiningOptions", "https://example.com/property20-photo1.jpg,https://example.com/property20-photo2.jpg", 1, "Modern Apartment in Victoria Island", "0C2E622E-49D1-4A80-AB68-A5AB3A213877" },
                    { new Guid("316f7467-d768-45b3-8a18-43662f6b67cb"), "4 Lekki Gardens, Lekki", 3, 4, "https://example.com/property4-cover.jpg", new DateTime(2023, 9, 19, 12, 21, 37, 699, DateTimeKind.Local).AddTicks(3480), "A modern terrace duplex with 4 bedrooms, 3 bathrooms, and contemporary design. This property is situated in the trendy Lekki neighborhood and offers spacious rooms, a sleek kitchen, and a rooftop terrace with stunning views.", 2, 600000.00m, 1, "Kitchen, Tv, Wifi, AirConditioning, RooftopTerrace", "https://example.com/property4-photo1.jpg,https://example.com/property4-photo2.jpg", 6, "Modern Terrace Duplex in Lekki", "9FE6F8FB-CE97-4DAE-AE02-0B3AC6B114FA" },
                    { new Guid("320cd9e3-90d4-4ed7-b591-7a2e7c114dc6"), "18 Cityscape Lane, Lagos", 1, 1, "https://example.com/property18-cover.jpg", new DateTime(2023, 9, 19, 12, 21, 37, 699, DateTimeKind.Local).AddTicks(3752), "Experience urban living in this contemporary loft with 1 bedroom, 1 bathroom, and breathtaking city views. This loft offers an open-concept design, modern furnishings, and easy access to Lagos nightlife.", 2, 100000.00m, 2, "Kitchen, Tv, Wifi, AirConditioning", "https://example.com/property18-photo1.jpg,https://example.com/property18-photo2.jpg", 1, "Contemporary Lagos Loft with City Views", "0C2E622E-49D1-4A80-AB68-A5AB3A213877" },
                    { new Guid("380f8cfa-65bc-49d5-a972-9e1bd41267b9"), "8 Riverside Street, Port Harcourt", 2, 3, "https://example.com/property8-cover.jpg", new DateTime(2023, 9, 19, 12, 21, 37, 699, DateTimeKind.Local).AddTicks(3672), "Discover modern living in this beautiful maisonette with 3 bedrooms, 2 bathrooms, and a contemporary design. Located in Port Harcourt's upscale neighborhood, this property offers a stylish kitchen, a private garden, and easy access to local amenities.", 1, 2800000.00m, 1, "Kitchen, Tv, Wifi, AirConditioning, Garden", "https://example.com/property8-photo1.jpg,https://example.com/property8-photo2.jpg", 7, "Modern Maisonette in Port Harcourt", "91F6AFD4-8D50-40B1-B09E-E799723E952D" },
                    { new Guid("41ab25b4-cbf3-4a04-a3a9-537007cc4f70"), "12 Green Hills Road, Enugu", 1, 2, "https://example.com/property12-cover.jpg", new DateTime(2023, 9, 19, 12, 21, 37, 699, DateTimeKind.Local).AddTicks(3704), "Experience eco-friendly living in this cozy cottage with 2 bedrooms, 1 bathroom, and sustainable features. Located in the serene hills of Enugu, this cottage offers a vegetable garden, solar & inverter, and a tranquil atmosphere.", 2, 1800000.00m, 1, "Kitchen, Tv, Wifi, SolarAndInverter, VegetableGarden", "https://example.com/property12-photo1.jpg,https://example.com/property12-photo2.jpg", 11, "Eco-Friendly Cottage in Enugu", "3F373D01-67C5-4FBC-92BB-3C84117CAE7B" },
                    { new Guid("42358c46-ffed-4d47-a1f3-88ee80dc1c79"), "7 Diplomat Avenue, Abuja", 6, 7, "https://example.com/property7-cover.jpg", new DateTime(2023, 9, 19, 12, 21, 37, 699, DateTimeKind.Local).AddTicks(3666), "Step into this majestic mansion with 7 bedrooms, 6 bathrooms, and exquisite architecture. Located in the diplomatic zone of Abuja, this property offers a grand entrance, lush gardens, and a private cinema room.", 1, 10000000.00m, 1, "Kitchen, Tv, Wifi, AirConditioning, Cinema, Garden", "https://example.com/property7-photo1.jpg,https://example.com/property7-photo2.jpg", 9, "Majestic Mansion in Abuja", "826E0C43-871D-4498-B343-8F8260E1127C" },
                    { new Guid("67ac20de-9974-41ae-a627-e989e00b3c0e"), "6 Marina Drive, Lagos", 4, 5, "https://example.com/property6-cover.jpg", new DateTime(2023, 9, 19, 12, 21, 37, 699, DateTimeKind.Local).AddTicks(3492), "Experience luxury living in this spacious penthouse with 5 bedrooms, 4 bathrooms, and breathtaking views of Lagos. This penthouse features a gourmet kitchen, private elevator access, and access to a rooftop pool and lounge.", 2, 1000000.00m, 1, "Kitchen, Tv, Wifi, AirConditioning, RooftopPool", "https://example.com/property6-photo1.jpg,https://example.com/property6-photo2.jpg", 8, "Luxurious Penthouse in Lagos", "826E0C43-871D-4498-B343-8F8260E1127C" },
                    { new Guid("7125c7d8-4976-497d-8e66-fe881a1d6f4f"), "1 Victoria Island, Lagos", 2, 3, "https://example.com/property1-cover.jpg", new DateTime(2023, 9, 19, 12, 21, 37, 699, DateTimeKind.Local).AddTicks(3444), "Experience luxury living in this spacious apartment located in the heart of Lagos Island. This stunning three-bedroom apartment features a modern kitchen, beautiful city views, and access to top-notch amenities.", 1, 2500000.00m, 1, "Kitchen, Wifi, AirConditioning, FreeParkingOnPremises", "https://example.com/property1-photo1.jpg,https://example.com/property1-photo2.jpg", 1, "Luxury Apartment in Lagos Island", "9FE6F8FB-CE97-4DAE-AE02-0B3AC6B114FA" },
                    { new Guid("7419c365-dbd8-45a2-a261-9e64415e0217"), "3 Ocean View Drive, Victoria Island", 2, 3, "https://example.com/property3-cover.jpg", new DateTime(2023, 9, 19, 12, 21, 37, 699, DateTimeKind.Local).AddTicks(3460), "A spacious apartment with 3 bedrooms, 2 bathrooms, and a stunning view of the ocean. Located in the upscale Victoria Island neighborhood, this property offers luxury living, a fully equipped kitchen, and access to a private pool and gym.", 1, 3500000.00m, 1, "Kitchen, Tv, Wifi, AirConditioning, Pool, Gym", "https://example.com/property3-photo1.jpg,https://example.com/property3-photo2.jpg", 1, "Spacious Apartment in Victoria Island", "9FE6F8FB-CE97-4DAE-AE02-0B3AC6B114FA" },
                    { new Guid("864d6259-ce6a-44c1-9827-e3ce37611e59"), "12 Garki, Abuja", 4, 5, "https://example.com/property2-cover.jpg", new DateTime(2023, 9, 19, 12, 21, 37, 699, DateTimeKind.Local).AddTicks(3454), "Indulge in luxury at this stunning villa in Abuja. This spacious five-bedroom villa features a private pool, lush gardens, and a fully equipped kitchen. Perfect for special events or a relaxing getaway.", 1, 5000000.00m, 1, "Kitchen, Tv, Wifi, AirConditioning, Pool, BBQGrill", "https://example.com/property2-photo1.jpg,https://example.com/property2-photo2.jpg", 9, "Luxury Villa in Abuja", "9FE6F8FB-CE97-4DAE-AE02-0B3AC6B114FA" },
                    { new Guid("88638ca9-855d-4c5e-98de-e34202245cde"), "16 Marina View, Lagos", 2, 2, "https://example.com/property16-cover.jpg", new DateTime(2023, 9, 19, 12, 21, 37, 699, DateTimeKind.Local).AddTicks(3740), "Enjoy modern living in this waterfront apartment with 2 bedrooms, 2 bathrooms, and stunning views of Lagos Island. This apartment features a fully equipped kitchen, fitness center, and 24/7 concierge service.", 3, 45000.00m, 1, "Kitchen, Tv, Wifi, AirConditioning, FitnessCenter, Concierge", "https://example.com/property16-photo1.jpg,https://example.com/property16-photo2.jpg", 1, "Modern Waterfront Apartment in Lagos Island", "0C2E622E-49D1-4A80-AB68-A5AB3A213877" },
                    { new Guid("88665e1f-1a02-4180-8710-05f15859be3b"), "11 Beachfront Lane, Lagos", 3, 4, "https://example.com/property11-cover.jpg", new DateTime(2023, 9, 19, 12, 21, 37, 699, DateTimeKind.Local).AddTicks(3693), "Escape to this seaside villa with 4 bedrooms, 3 bathrooms, and direct access to the beach. This villa offers a fully equipped kitchen, a private swimming pool, and breathtaking sunset views over the ocean.", 1, 5500000.00m, 1, "Kitchen, Tv, Wifi, AirConditioning, PrivatePool, BeachAccess", "https://example.com/property11-photo1.jpg,https://example.com/property11-photo2.jpg", 10, "Seaside Villa in Lagos", "3F373D01-67C5-4FBC-92BB-3C84117CAE7B" },
                    { new Guid("9e5cd147-e5e8-4aa9-9f7c-d3fc8ad36212"), "9 Riverside Drive, Port Harcourt", 5, 6, "https://example.com/property9-cover.jpg", new DateTime(2023, 9, 19, 12, 21, 37, 699, DateTimeKind.Local).AddTicks(3679), "Experience riverside living in this grand mansion with 6 bedrooms, 5 bathrooms, and panoramic views of the river. This mansion boasts a private dock, a spacious dining hall, and beautifully landscaped gardens.", 1, 7500000.00m, 1, "Kitchen, Tv, Wifi, AirConditioning, PrivateDock, Garden", "https://example.com/property9-photo1.jpg,https://example.com/property9-photo2.jpg", 9, "Riverside Mansion in Port Harcourt", "91F6AFD4-8D50-40B1-B09E-E799723E952D" },
                    { new Guid("c8848cbe-4e01-4553-9517-eba790bd1636"), "14 Forest Retreat, Ondo", 1, 1, "https://example.com/property14-cover.jpg", new DateTime(2023, 9, 19, 12, 21, 37, 699, DateTimeKind.Local).AddTicks(3728), "Escape to nature in this secluded cabin with 1 bedroom, 1 bathroom, and a tranquil forest setting. Located deep in the Ondo Forest, this cabin offers a fireplace, hiking trails, and a true getaway from the city.", 2, 120000.00m, 1, "Kitchen, Fireplace, HikingTrails", "https://example.com/property14-photo1.jpg,https://example.com/property14-photo2.jpg", 12, "Secluded Cabin in Ondo Forest", "0C2E622E-49D1-4A80-AB68-A5AB3A213877" },
                    { new Guid("c89148ef-f14d-4411-a977-0ab4aa5628aa"), "10 Lekki Gardens, Lekki", 2, 3, "https://example.com/property10-cover.jpg", new DateTime(2023, 9, 19, 12, 21, 37, 699, DateTimeKind.Local).AddTicks(3686), "Discover elegance in this terrace duplex with 3 bedrooms, 2 bathrooms, and modern design. Located in Lekki's upscale neighborhood, this property offers a well-appointed kitchen, a cozy living room, and a private courtyard.", 2, 300000.00m, 1, "Kitchen, Tv, Wifi, AirConditioning, PrivateCourtyard", "https://example.com/property10-photo1.jpg,https://example.com/property10-photo2.jpg", 6, "Elegant Terrace Duplex in Lekki", "3F373D01-67C5-4FBC-92BB-3C84117CAE7B" },
                    { new Guid("c921981a-6855-4968-9c04-ed6025f54606"), "15 Oceanview Road, Lagos", 3, 4, "https://example.com/property15-cover.jpg", new DateTime(2023, 9, 19, 12, 21, 37, 699, DateTimeKind.Local).AddTicks(3734), "Indulge in luxury at this beachfront villa with 4 bedrooms, 3 bathrooms, and direct access to the ocean. This villa offers a private chef, infinity pool, and stunning sunset views over the Atlantic.", 3, 100000.00m, 1, "Kitchen, Tv, Wifi, AirConditioning, Pool, PrivateChef", "https://example.com/property15-photo1.jpg,https://example.com/property15-photo2.jpg", 10, "Luxury Beachfront Villa in Lagos", "0C2E622E-49D1-4A80-AB68-A5AB3A213877" },
                    { new Guid("e2b4ff8a-7527-492f-8efe-c8e227470867"), "19 Lagoonview Drive, Lagos", 1, 1, "https://example.com/property19-cover.jpg", new DateTime(2023, 9, 19, 12, 21, 37, 699, DateTimeKind.Local).AddTicks(3758), "Escape to this serene waterfront retreat with 1 bedroom, 1 bathroom, and direct access to the lagoon. This retreat features a private boat dock, lush gardens, and a peaceful atmosphere.", 2, 200000.00m, 2, "Kitchen, Tv, Wifi, LagoonAccess, BoatDock, Gardens", "https://example.com/property19-photo1.jpg,https://example.com/property19-photo2.jpg", 3, "Serene Waterfront Retreat in Lagos", "0C2E622E-49D1-4A80-AB68-A5AB3A213877" },
                    { new Guid("f7c70aa3-2877-4ea4-8f78-2194f3cbc684"), "17 Skyline Towers, Lagos", 2, 3, "https://example.com/property17-cover.jpg", new DateTime(2023, 9, 19, 12, 21, 37, 699, DateTimeKind.Local).AddTicks(3746), "Live in luxury at this Lagos penthouse with 3 bedrooms, 2 bathrooms, and panoramic skyline views. This penthouse offers a rooftop terrace, spa, and private elevator access.", 1, 5500000.00m, 1, "Kitchen, Tv, Wifi, AirConditioning, RooftopTerrace, Spa", "https://example.com/property17-photo1.jpg,https://example.com/property17-photo2.jpg", 8, "Luxurious Lagos Penthouse with Skyline Views", "0C2E622E-49D1-4A80-AB68-A5AB3A213877" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_UserId",
                table: "Properties",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
