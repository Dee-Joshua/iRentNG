using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IRentNG.Repository.Migrations
{
    /// <inheritdoc />
    public partial class RefactoredModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AmenityProperty");

            migrationBuilder.DropTable(
                name: "Amenities");

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

            migrationBuilder.AddColumn<string>(
                name: "PropertyAmenities",
                table: "Properties",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PermanentAddress",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "309f61ac-3a18-484e-8550-28405f4a73dc", null, "Landlord", "LANDLORD" },
                    { "8be6d05e-0579-4565-8368-f9b62614c105", null, "Tenant", "TENANT" },
                    { "ed7205a6-4a00-4930-a994-616bf79318ad", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "579cb2f2-5256-4014-8279-08f527b7f302",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7566e31-ecd8-434c-b57a-384df685081e", "AQAAAAIAAYagAAAAEH88nbsiF3hp3VhLDeJZlituvMKKDg6VI8PPlKz3ImWxq3m1GR1HjrCqYEj7VYN38w==", "49428798-6933-4cac-ba91-c7a4db7c8f4a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a5c9a15-7f19-46ff-9e1d-62d617126006",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a376a5b-3059-4f98-acdb-7b638c3052cd", "AQAAAAIAAYagAAAAEGx79S9jJlkts1DAQLDrNUpy1hqMjNeBjvfaKDNoxO8NDUyeyXsdRSRQ+C3z6ar7Dw==", "fd1c98d9-f4ae-4175-9c24-f185c3217f63" });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: new Guid("1b5e8863-906d-4a9d-b4b3-10c6100b6fc9"),
                column: "PropertyAmenities",
                value: null);

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: new Guid("afe12c0a-880e-4559-9725-fdd49d06f91c"),
                column: "PropertyAmenities",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "309f61ac-3a18-484e-8550-28405f4a73dc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8be6d05e-0579-4565-8368-f9b62614c105");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed7205a6-4a00-4930-a994-616bf79318ad");

            migrationBuilder.DropColumn(
                name: "PropertyAmenities",
                table: "Properties");

            migrationBuilder.AlterColumn<string>(
                name: "PermanentAddress",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Amenities",
                columns: table => new
                {
                    AmenityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amenities", x => x.AmenityId);
                });

            migrationBuilder.CreateTable(
                name: "AmenityProperty",
                columns: table => new
                {
                    AmenitiesId = table.Column<int>(type: "int", nullable: false),
                    PropertiesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmenityProperty", x => new { x.AmenitiesId, x.PropertiesId });
                    table.ForeignKey(
                        name: "FK_AmenityProperty_Amenities_AmenitiesId",
                        column: x => x.AmenitiesId,
                        principalTable: "Amenities",
                        principalColumn: "AmenityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AmenityProperty_Properties_PropertiesId",
                        column: x => x.PropertiesId,
                        principalTable: "Properties",
                        principalColumn: "PropertyId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "579cb2f2-5256-4014-8279-08f527b7f302",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8a42467-9e45-4e52-bb24-4fafd5e19ea6", "AQAAAAIAAYagAAAAENwyUAfEMb+oQnrp5/lJ5jP4YnXz5ecAXS/5OjlQETk2M3PWlGeWO8ORQZnBe6UPYQ==", "800e925b-19d6-4653-a071-2b2d594dc5ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a5c9a15-7f19-46ff-9e1d-62d617126006",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfecabd5-04d2-430c-9ccc-c723fd157459", "AQAAAAIAAYagAAAAEJ/Ja7X9mFmIgF/RSqqvBheJzCYkvu9SuiLf0vUqR0nV9eUTUIlSsxxGgdQ3IkqvDg==", "103ec15c-72b1-409c-81e4-422b947db361" });

            migrationBuilder.InsertData(
                table: "AmenityProperty",
                columns: new[] { "AmenitiesId", "PropertiesId" },
                values: new object[,]
                {
                    { 2, new Guid("1b5e8863-906d-4a9d-b4b3-10c6100b6fc9") },
                    { 3, new Guid("1b5e8863-906d-4a9d-b4b3-10c6100b6fc9") },
                    { 4, new Guid("afe12c0a-880e-4559-9725-fdd49d06f91c") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AmenityProperty_PropertiesId",
                table: "AmenityProperty",
                column: "PropertiesId");
        }
    }
}
