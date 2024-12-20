using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertyManager.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UserRefreshToken : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RefreshTokens_UserId",
                schema: "admin",
                table: "RefreshTokens");

            migrationBuilder.UpdateData(
                schema: "admin",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "530b21d4-4dd9-4749-9444-ee1384d37d38",
                column: "ConcurrencyStamp",
                value: "fb8939f9-dd53-411d-844c-a3f8abe4da42");

            migrationBuilder.UpdateData(
                schema: "admin",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "7db8bdb6-8ffe-4f73-903f-fe0424d52e10",
                column: "ConcurrencyStamp",
                value: "09c72f45-0b4f-47df-8b4f-61b15fbf8797");

            migrationBuilder.UpdateData(
                schema: "admin",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c79c336b-5210-411e-b8c5-f6f210d06204",
                column: "ConcurrencyStamp",
                value: "9cf00316-8903-483c-8b0e-ab1a4e7f45c8");

            migrationBuilder.UpdateData(
                schema: "admin",
                table: "Users",
                keyColumn: "Id",
                keyValue: "52f9a82a-e4b6-4f67-ae91-2e173aa21a1a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6611a6f-9c7d-4c3f-978d-80067f860b4e", "AQAAAAIAAYagAAAAEMMgQo1y2R9TlnCdjOERqqDvT3gffOD/WyZJaBVHVV9BCneKdZDIyEpMunZokRcZTw==", "37ff4fa6-5d28-4e5c-afc7-d5b1a19e26cb" });

            migrationBuilder.UpdateData(
                schema: "admin",
                table: "Users",
                keyColumn: "Id",
                keyValue: "a901fdf4-edcb-4b6d-9a65-40df5b062f24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d08daa79-1cc4-4135-8a30-c647b05e0ab6", "AQAAAAIAAYagAAAAEEQR2ANu/wyqnnTd3VCPkGi+9eC7423RulKIDRzRbdhdYCdQPMUa4abFURwcOAIRTw==", "eb2450c1-ad53-4dcf-a8cd-4c751972d4df" });

            migrationBuilder.UpdateData(
                schema: "admin",
                table: "Users",
                keyColumn: "Id",
                keyValue: "e63a9b1c-2f89-406e-a5dc-d6ebe5cdf05a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a8da652-6aa3-4801-b57c-5e0eb6a5c62a", "AQAAAAIAAYagAAAAEHyf3fEytP2MEWkrzjRnvsQxCRtr95BvKdVQ7MGqX6mhIaoQ99wFYd1Z9O1JUj3Xxg==", "49f6cc36-003c-4586-9d08-ab5f5b63ca5b" });

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_UserId",
                schema: "admin",
                table: "RefreshTokens",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RefreshTokens_UserId",
                schema: "admin",
                table: "RefreshTokens");

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

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_UserId",
                schema: "admin",
                table: "RefreshTokens",
                column: "UserId",
                unique: true);
        }
    }
}
