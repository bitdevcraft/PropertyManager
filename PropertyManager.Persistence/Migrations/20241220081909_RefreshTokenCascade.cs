using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertyManager.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RefreshTokenCascade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RefreshTokens_Users_UserId",
                schema: "admin",
                table: "RefreshTokens");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                schema: "admin",
                table: "RefreshTokens",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "admin",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "530b21d4-4dd9-4749-9444-ee1384d37d38",
                column: "ConcurrencyStamp",
                value: "0a73be33-9ea0-426a-aefd-4dc46eee931c");

            migrationBuilder.UpdateData(
                schema: "admin",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "7db8bdb6-8ffe-4f73-903f-fe0424d52e10",
                column: "ConcurrencyStamp",
                value: "a82c5d07-68df-42f9-87b3-b6c68b097cac");

            migrationBuilder.UpdateData(
                schema: "admin",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c79c336b-5210-411e-b8c5-f6f210d06204",
                column: "ConcurrencyStamp",
                value: "55eda48f-b941-4abb-a5b6-d33aeca31637");

            migrationBuilder.UpdateData(
                schema: "admin",
                table: "Users",
                keyColumn: "Id",
                keyValue: "52f9a82a-e4b6-4f67-ae91-2e173aa21a1a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52b03796-a2a7-41a7-845f-c8f21107936b", "AQAAAAIAAYagAAAAEAqUCz1Nf3Tn3b27RBFYYuv/mTmMLoaDezAWnjamue4+/1Cj2xyerxUfD6jZTSBGdg==", "32216f66-8b1f-4075-81a9-d22cb02c6670" });

            migrationBuilder.UpdateData(
                schema: "admin",
                table: "Users",
                keyColumn: "Id",
                keyValue: "a901fdf4-edcb-4b6d-9a65-40df5b062f24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5fb92fc-4ca1-4411-a04d-22b15998d71a", "AQAAAAIAAYagAAAAECHChE7AryeI14bvNBy5/s8YjMVDekaU75IFdg/JmvAPwSjAY3vyvgnBiklRi664jg==", "f10b9446-8e90-4cd7-ba66-6c62c7a87baf" });

            migrationBuilder.UpdateData(
                schema: "admin",
                table: "Users",
                keyColumn: "Id",
                keyValue: "e63a9b1c-2f89-406e-a5dc-d6ebe5cdf05a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f12a4581-cddc-4c27-a708-d5805cdde216", "AQAAAAIAAYagAAAAECvcaQElzTlnLWCwySq1WonX2oW4xjog/4fx1oGLrle/WcF3mMBEZSlqcYR+/SwBag==", "15ed4f48-1a4e-4b14-aff0-cd1bd579e2c6" });

            migrationBuilder.AddForeignKey(
                name: "FK_RefreshTokens_Users_UserId",
                schema: "admin",
                table: "RefreshTokens",
                column: "UserId",
                principalSchema: "admin",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RefreshTokens_Users_UserId",
                schema: "admin",
                table: "RefreshTokens");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                schema: "admin",
                table: "RefreshTokens",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

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

            migrationBuilder.AddForeignKey(
                name: "FK_RefreshTokens_Users_UserId",
                schema: "admin",
                table: "RefreshTokens",
                column: "UserId",
                principalSchema: "admin",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
