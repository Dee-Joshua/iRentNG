using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IRentNG.Repository.Migrations
{
    /// <inheritdoc />
    public partial class RefactoredMode2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "ProfilePicture",
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "ProfilePicture",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
