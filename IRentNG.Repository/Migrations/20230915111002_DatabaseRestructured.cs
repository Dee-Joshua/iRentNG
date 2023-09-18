using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IRentNG.Repository.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseRestructured : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PropertyPhotos");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "23cc3402-c74c-4600-bedc-94f8edd69255");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40afcd0a-25c1-48f9-bf05-87fc8bdf52a7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "782ad6bc-8012-4812-a9a2-5056c70a2b21");

            migrationBuilder.AlterColumn<string>(
                name: "CoverPhotoURL",
                table: "Properties",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Properties",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "PropertyPhotosURLs",
                table: "Properties",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateJoined",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "72914964-9e49-496b-8848-2a2854e77901", null, "Tenant", "TENANT" },
                    { "921b4f4e-4f7e-43b2-bce1-a43948cad900", null, "Administrator", "ADMINISTRATOR" },
                    { "e656bf26-5fbc-46c1-951b-1b47bd000391", null, "Landlord", "LANDLORD" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "579cb2f2-5256-4014-8279-08f527b7f302",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da235d60-84a5-4083-a578-5daf2e3e8a77", new DateTime(2023, 9, 15, 12, 10, 2, 289, DateTimeKind.Local).AddTicks(7018), "AQAAAAIAAYagAAAAENiLnymUkz9coSZiYS6GQq/UsTuJmlBO3NSoAmZJi1uKDLq/qOk4th9WEOyW93tAxA==", "a6f4ad3f-3a4c-4daf-b196-6569d5be3fbe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a5c9a15-7f19-46ff-9e1d-62d617126006",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32da9622-5c19-4de6-8624-6b252d7f4a81", new DateTime(2023, 9, 15, 12, 10, 2, 351, DateTimeKind.Local).AddTicks(9252), "AQAAAAIAAYagAAAAEOJfU60QsV5TegDnZ9NHexrTndJhVlwKMUsSf8pLh/L2e83NSjqTLql5YuwrYIeq6A==", "13b2997e-cf4e-4ff5-a008-bbb5988f9e8c" });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: new Guid("1b5e8863-906d-4a9d-b4b3-10c6100b6fc9"),
                columns: new[] { "CreatedDate", "PropertyPhotosURLs" },
                values: new object[] { new DateTime(2023, 9, 15, 12, 10, 2, 454, DateTimeKind.Local).AddTicks(8820), null });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: new Guid("afe12c0a-880e-4559-9725-fdd49d06f91c"),
                columns: new[] { "CreatedDate", "PropertyPhotosURLs" },
                values: new object[] { new DateTime(2023, 9, 15, 12, 10, 2, 454, DateTimeKind.Local).AddTicks(8909), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "PropertyPhotosURLs",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "DateJoined",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "CoverPhotoURL",
                table: "Properties",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "PropertyPhotos",
                columns: table => new
                {
                    PhotoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyPhotos", x => x.PhotoId);
                    table.ForeignKey(
                        name: "FK_PropertyPhotos_Properties_PropertyID",
                        column: x => x.PropertyID,
                        principalTable: "Properties",
                        principalColumn: "PropertyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "23cc3402-c74c-4600-bedc-94f8edd69255", null, "Landlord", "LANDLORD" },
                    { "40afcd0a-25c1-48f9-bf05-87fc8bdf52a7", null, "Tenant", "TENANT" },
                    { "782ad6bc-8012-4812-a9a2-5056c70a2b21", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "579cb2f2-5256-4014-8279-08f527b7f302",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b34d387-84b2-4d4d-af97-4104a92b12e5", "AQAAAAIAAYagAAAAEJ/yj1+3wLurTEOJx0dA6KrNHQLBBqr3fJ2S/MKb3BUsW86UzuCWdy+fgUlM20gpWQ==", "54257d4e-bbbe-46dd-a5ee-d31cc85315dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a5c9a15-7f19-46ff-9e1d-62d617126006",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1419291c-1256-44ba-abbd-db1a58fd5bb3", "AQAAAAIAAYagAAAAEEtceX8+g9pPNw0GZIaD6lwZPXsfjK1qvygJlvQj3eahps/oW97xi7bpCM1phnY5uw==", "59c6e2ce-40b0-487d-a554-56d090d7e75a" });

            migrationBuilder.CreateIndex(
                name: "IX_PropertyPhotos_PropertyID",
                table: "PropertyPhotos",
                column: "PropertyID");
        }
    }
}
