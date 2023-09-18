using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IRentNG.Repository.Migrations
{
    /// <inheritdoc />
    public partial class InitailData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21957615-4d8b-45c8-bfd7-fbcf5733bb4d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "771a1cc1-9ca1-4866-8451-4fcc3c5bb3e0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b9f01bc6-97b3-42ef-b284-be1c18dcd9e1");

            migrationBuilder.AddColumn<string>(
                name: "PermanentAddress",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "AmenityId", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "Kitchen" },
                    { 3, "Tv" },
                    { 4, "Wifi" },
                    { 5, "Washing Machine" },
                    { 6, "Air Conditioning" },
                    { 7, "Free Parking On Premises" },
                    { 8, "Dedicated Workspace" },
                    { 9, "Cinema" },
                    { 10, "Pool" },
                    { 11, "Hot Tub" },
                    { 12, "Veranda" },
                    { 13, "BBQ Grill" },
                    { 14, "Pool Table" },
                    { 15, "Piano" },
                    { 16, "Exercise Equipment" },
                    { 17, "Smoke Alarm" },
                    { 18, "First Aid Kit" },
                    { 19, "Fire Extinguisher" },
                    { 20, "Furnitures" },
                    { 21, "24HoursElectricity" },
                    { 22, "Estate" },
                    { 23, "FullyServicedEstate" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2fb49c49-7673-4509-994f-6a151cd70e02", null, "Tenant", "TENANT" },
                    { "51e14401-6a9a-4b59-9b25-7c6c543179f2", null, "Landlord", "LANDLORD" },
                    { "70d986bf-9830-495f-80a9-b04e196dd54b", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PermanentAddress", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "579cb2f2-5256-4014-8279-08f527b7f302", 0, "f8a42467-9e45-4e52-bb24-4fafd5e19ea6", "user1@example.com", true, "John Doe", false, null, "USER1@EXAMPLE.COM", "USER1@EXAMPLE.COM", "AQAAAAIAAYagAAAAENwyUAfEMb+oQnrp5/lJ5jP4YnXz5ecAXS/5OjlQETk2M3PWlGeWO8ORQZnBe6UPYQ==", "123 Main Street", null, false, "https://example.com/user1.jpg", "800e925b-19d6-4653-a071-2b2d594dc5ce", false, "user1@example.com" },
                    { "6a5c9a15-7f19-46ff-9e1d-62d617126006", 0, "cfecabd5-04d2-430c-9ccc-c723fd157459", "user2@example.com", true, "Jane Smith", false, null, "USER2@EXAMPLE.COM", "USER2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ/Ja7X9mFmIgF/RSqqvBheJzCYkvu9SuiLf0vUqR0nV9eUTUIlSsxxGgdQ3IkqvDg==", "456 Elm Street", null, false, "https://example.com/user2.jpg", "103ec15c-72b1-409c-81e4-422b947db361", false, "user2@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "PropertyId", "Address", "Bathrooms", "Bedrooms", "CoverPhotoURL", "Description", "Duration", "Price", "Privacy", "Structure", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("1b5e8863-906d-4a9d-b4b3-10c6100b6fc9"), "123 Main Street", 1, 2, "https://example.com/coverphoto1.jpg", "Description of Sample Property 1", 2, 100.00m, 1, 1, "Sample Property 1", "579CB2F2-5256-4014-8279-08F527B7F302" },
                    { new Guid("afe12c0a-880e-4559-9725-fdd49d06f91c"), "456 Elm Street", 1, 1, "https://example.com/coverphoto2.jpg", "Description of Sample Property 2", 4, 50.00m, 2, 3, "Sample Property 2", "6A5C9A15-7F19-46FF-9E1D-62D617126006" }
                });

            migrationBuilder.InsertData(
                table: "AmenityProperty",
                columns: new[] { "AmenitiesId", "PropertiesId" },
                values: new object[,]
                {
                    { 2, new Guid("1b5e8863-906d-4a9d-b4b3-10c6100b6fc9") },
                    { 3, new Guid("1b5e8863-906d-4a9d-b4b3-10c6100b6fc9") },
                    { 4, new Guid("afe12c0a-880e-4559-9725-fdd49d06f91c") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "AmenityProperty",
                keyColumns: new[] { "AmenitiesId", "PropertiesId" },
                keyValues: new object[] { 2, new Guid("1b5e8863-906d-4a9d-b4b3-10c6100b6fc9") });

            migrationBuilder.DeleteData(
                table: "AmenityProperty",
                keyColumns: new[] { "AmenitiesId", "PropertiesId" },
                keyValues: new object[] { 3, new Guid("1b5e8863-906d-4a9d-b4b3-10c6100b6fc9") });

            migrationBuilder.DeleteData(
                table: "AmenityProperty",
                keyColumns: new[] { "AmenitiesId", "PropertiesId" },
                keyValues: new object[] { 4, new Guid("afe12c0a-880e-4559-9725-fdd49d06f91c") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2fb49c49-7673-4509-994f-6a151cd70e02");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51e14401-6a9a-4b59-9b25-7c6c543179f2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70d986bf-9830-495f-80a9-b04e196dd54b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "579cb2f2-5256-4014-8279-08f527b7f302");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a5c9a15-7f19-46ff-9e1d-62d617126006");

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: new Guid("1b5e8863-906d-4a9d-b4b3-10c6100b6fc9"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: new Guid("afe12c0a-880e-4559-9725-fdd49d06f91c"));

            migrationBuilder.DropColumn(
                name: "PermanentAddress",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "21957615-4d8b-45c8-bfd7-fbcf5733bb4d", null, "Tenant", "TENANT" },
                    { "771a1cc1-9ca1-4866-8451-4fcc3c5bb3e0", null, "Administrator", "ADMINISTRATOR" },
                    { "b9f01bc6-97b3-42ef-b284-be1c18dcd9e1", null, "Landlord", "LANDLORD" }
                });
        }
    }
}
