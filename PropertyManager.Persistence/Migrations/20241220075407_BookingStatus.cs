using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PropertyManager.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class BookingStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookingStatus",
                schema: "app",
                columns: table => new
                {
                    Name = table.Column<string>(type: "text", nullable: false),
                    Sequence = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NormalizedName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingStatus", x => x.Name);
                });

            migrationBuilder.InsertData(
                schema: "app",
                table: "BookingStatus",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "Cancelled", "CANCELLED" },
                    { "Completed", "COMPLETED" },
                    { "Confirmed", "CONFIRMED" },
                    { "Pending", "PENDING" }
                });

            migrationBuilder.UpdateData(
                schema: "admin",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "530b21d4-4dd9-4749-9444-ee1384d37d38",
                column: "ConcurrencyStamp",
                value: "c16a0fdd-0e98-4d84-a1b3-a375ae1547b6");

            migrationBuilder.UpdateData(
                schema: "admin",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "7db8bdb6-8ffe-4f73-903f-fe0424d52e10",
                column: "ConcurrencyStamp",
                value: "dbba757c-3bc1-4cd4-9e84-579ea8c00cc0");

            migrationBuilder.UpdateData(
                schema: "admin",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c79c336b-5210-411e-b8c5-f6f210d06204",
                column: "ConcurrencyStamp",
                value: "8135d6d5-f0a7-47b1-8b29-fb159cafbd6e");

            migrationBuilder.UpdateData(
                schema: "admin",
                table: "Users",
                keyColumn: "Id",
                keyValue: "52f9a82a-e4b6-4f67-ae91-2e173aa21a1a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7ae3c98-a5fa-4c63-8543-4ef474bccb91", "AQAAAAIAAYagAAAAELvqEAol2C4IG0bLxilpirl7HtYGFKpcyEHvZQY/Zg+3u5+vFHUc9d4ZdpQaCAczUg==", "88bfb9f8-160f-49b6-8778-cd971ca2eb65" });

            migrationBuilder.UpdateData(
                schema: "admin",
                table: "Users",
                keyColumn: "Id",
                keyValue: "a901fdf4-edcb-4b6d-9a65-40df5b062f24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93536d9f-a060-46f7-be67-bd15ef011c92", "AQAAAAIAAYagAAAAECWkvZp8e6HcGsc5IV3Lg3SGxX0eKW5+wziegf1j5Ma12VkFgUGOIb873dKY2Q8DbA==", "ddda9485-17f1-45a2-8de2-2e87f1bc42ea" });

            migrationBuilder.UpdateData(
                schema: "admin",
                table: "Users",
                keyColumn: "Id",
                keyValue: "e63a9b1c-2f89-406e-a5dc-d6ebe5cdf05a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18355fbf-3958-4e17-9b9f-7dd9457b7c5f", "AQAAAAIAAYagAAAAELyHbHKbCcTTtYwANZFRz1cerG4+Mb187zIpclOJWePQXffJKHZ87ekS0ZCUwPOsQw==", "992b9fa8-61e6-4343-8e8f-367ea1daf449" });

            migrationBuilder.CreateIndex(
                name: "IX_BookingStatus_NormalizedName",
                schema: "app",
                table: "BookingStatus",
                column: "NormalizedName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookingStatus",
                schema: "app");

            migrationBuilder.UpdateData(
                schema: "admin",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "530b21d4-4dd9-4749-9444-ee1384d37d38",
                column: "ConcurrencyStamp",
                value: "0e443a58-b85f-4cc3-b886-ff801d249df8");

            migrationBuilder.UpdateData(
                schema: "admin",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "7db8bdb6-8ffe-4f73-903f-fe0424d52e10",
                column: "ConcurrencyStamp",
                value: "58826b5a-1aca-40cc-9f32-3d07c570affc");

            migrationBuilder.UpdateData(
                schema: "admin",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c79c336b-5210-411e-b8c5-f6f210d06204",
                column: "ConcurrencyStamp",
                value: "42e94518-a9ab-45b2-bc08-d6bf5bc8f441");

            migrationBuilder.UpdateData(
                schema: "admin",
                table: "Users",
                keyColumn: "Id",
                keyValue: "52f9a82a-e4b6-4f67-ae91-2e173aa21a1a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb5dc4e5-82ad-46fa-a4df-e4e081051f8f", "AQAAAAIAAYagAAAAELtvpe2OQ0/uiYOBYlthKfuMMY5qbzPG9Vfr2R+ZVeX1XXCjFU4X3DQUQXOSSqNnjw==", "12e19972-f59b-46ea-91b9-56e3362dd3fb" });

            migrationBuilder.UpdateData(
                schema: "admin",
                table: "Users",
                keyColumn: "Id",
                keyValue: "a901fdf4-edcb-4b6d-9a65-40df5b062f24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b90c398a-41ef-40d3-a015-063120af9cfb", "AQAAAAIAAYagAAAAEHAqNZ546PJUEeI5u6yu851JJTb81Kd9SHXAwPtz/4gTR1Syhpm2Cu6N/lKEfhoVhg==", "69387182-bad1-4c9f-9e9c-b4794ce448f4" });

            migrationBuilder.UpdateData(
                schema: "admin",
                table: "Users",
                keyColumn: "Id",
                keyValue: "e63a9b1c-2f89-406e-a5dc-d6ebe5cdf05a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1397cd4-5118-4206-9051-e83edaff06f7", "AQAAAAIAAYagAAAAEMGa3VSK4UMVE3Gr7ENDG/14iQv2QVBnEFH9ZxwRlY33p1KkwSh5PV1/x6VdOjP/Mw==", "f309188b-35c6-45af-8272-40d28da98765" });
        }
    }
}
