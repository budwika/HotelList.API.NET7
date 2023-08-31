using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelList.API.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9807a345-5074-4986-9efc-9ee6e2ffdee5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aff73591-9d7a-4c87-8c77-837cf30ef9c5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "45555876-f091-47a9-a110-cd5b1f8991dd", null, "Administrator", "ADMINISTRATOR" },
                    { "74702acc-7774-47e2-a89d-32ac1149d7e3", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45555876-f091-47a9-a110-cd5b1f8991dd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74702acc-7774-47e2-a89d-32ac1149d7e3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9807a345-5074-4986-9efc-9ee6e2ffdee5", null, "User", "USER" },
                    { "aff73591-9d7a-4c87-8c77-837cf30ef9c5", null, "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
