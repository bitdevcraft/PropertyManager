using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using PropertyManager.Domain.Entities.Models.Bookings;

#nullable disable

namespace PropertyManager.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ModelConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "app");

            migrationBuilder.CreateTable(
                name: "PaymentPlans",
                schema: "app",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                schema: "app",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentPlanMilestones",
                schema: "app",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    TotalPercentage = table.Column<decimal>(type: "numeric", nullable: false),
                    PaymentCount = table.Column<int>(type: "integer", nullable: false),
                    IntervalType = table.Column<int>(type: "integer", nullable: false),
                    PaymentPlanId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentPlanMilestones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentPlanMilestones_PaymentPlans_PaymentPlanId",
                        column: x => x.PaymentPlanId,
                        principalSchema: "app",
                        principalTable: "PaymentPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectPaymentPlans",
                schema: "app",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    ProjectId = table.Column<string>(type: "text", nullable: false),
                    PaymentPlanId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectPaymentPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectPaymentPlans_PaymentPlans_PaymentPlanId",
                        column: x => x.PaymentPlanId,
                        principalSchema: "app",
                        principalTable: "PaymentPlans",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectPaymentPlans_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalSchema: "app",
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                schema: "app",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    ProjectId = table.Column<string>(type: "text", nullable: true),
                    TimeIn = table.Column<TimeSpan>(type: "interval", nullable: false),
                    TimeOut = table.Column<TimeSpan>(type: "interval", nullable: false),
                    PropertyType = table.Column<string>(type: "text", nullable: true),
                    ListingType = table.Column<string>(type: "text", nullable: true),
                    PropertyStatus = table.Column<string>(type: "text", nullable: true),
                    Country = table.Column<string>(type: "text", nullable: true),
                    State = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    Neighborhood = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    Latitude = table.Column<double>(type: "double precision", nullable: false),
                    Longitude = table.Column<double>(type: "double precision", nullable: false),
                    Landmark = table.Column<string>(type: "text", nullable: true),
                    OwnerName = table.Column<string>(type: "text", nullable: true),
                    OwnershipType = table.Column<string>(type: "text", nullable: true),
                    TitleDeedNumber = table.Column<string>(type: "text", nullable: true),
                    LegalApprovals = table.Column<string>(type: "text", nullable: true),
                    TenureInformation = table.Column<string>(type: "text", nullable: true),
                    TotalArea = table.Column<double>(type: "double precision", nullable: false),
                    PlotArea = table.Column<double>(type: "double precision", nullable: false),
                    BuiltUpArea = table.Column<double>(type: "double precision", nullable: false),
                    NumberOfBedrooms = table.Column<int>(type: "integer", nullable: false),
                    NumberOfBathrooms = table.Column<int>(type: "integer", nullable: false),
                    NumberOfFloors = table.Column<int>(type: "integer", nullable: false),
                    BalconySize = table.Column<double>(type: "double precision", nullable: false),
                    GardenSize = table.Column<double>(type: "double precision", nullable: false),
                    ParkingSpaces = table.Column<int>(type: "integer", nullable: false),
                    FloorNumber = table.Column<int>(type: "integer", nullable: false),
                    FurnishingStatus = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    PricePerUnitArea = table.Column<decimal>(type: "numeric", nullable: false),
                    MaintenanceFees = table.Column<decimal>(type: "numeric", nullable: false),
                    SecurityDeposit = table.Column<decimal>(type: "numeric", nullable: false),
                    OtherCharges = table.Column<decimal>(type: "numeric", nullable: false),
                    HasElectricity = table.Column<bool>(type: "boolean", nullable: false),
                    HasWater = table.Column<bool>(type: "boolean", nullable: false),
                    AirConditioningType = table.Column<string>(type: "text", nullable: true),
                    HeatingSystem = table.Column<string>(type: "text", nullable: true),
                    InternetConnectivity = table.Column<bool>(type: "boolean", nullable: false),
                    UtilityMeters = table.Column<string>(type: "text", nullable: true),
                    SwimmingPool = table.Column<bool>(type: "boolean", nullable: false),
                    Gym = table.Column<bool>(type: "boolean", nullable: false),
                    ChildrenPlayArea = table.Column<bool>(type: "boolean", nullable: false),
                    Security = table.Column<bool>(type: "boolean", nullable: false),
                    Clubhouse = table.Column<bool>(type: "boolean", nullable: false),
                    SmartHomeFeatures = table.Column<bool>(type: "boolean", nullable: false),
                    StorageRoom = table.Column<bool>(type: "boolean", nullable: false),
                    Elevator = table.Column<bool>(type: "boolean", nullable: false),
                    LaundryRoom = table.Column<bool>(type: "boolean", nullable: false),
                    View = table.Column<string>(type: "text", nullable: true),
                    Orientation = table.Column<string>(type: "text", nullable: true),
                    Accessibility = table.Column<string>(type: "text", nullable: true),
                    LandUseType = table.Column<string>(type: "text", nullable: true),
                    SoilQuality = table.Column<string>(type: "text", nullable: true),
                    ConstructionYear = table.Column<int>(type: "integer", nullable: false),
                    Condition = table.Column<string>(type: "text", nullable: true),
                    RenovationDetails = table.Column<string>(type: "text", nullable: true),
                    OccupancyStatus = table.Column<string>(type: "text", nullable: true),
                    HandoverDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ImageUrls = table.Column<List<string>>(type: "text[]", nullable: false),
                    VirtualTourUrl = table.Column<string>(type: "text", nullable: true),
                    VideoUrls = table.Column<List<string>>(type: "text[]", nullable: false),
                    AgentContactInfo = table.Column<string>(type: "text", nullable: true),
                    PropertyTax = table.Column<decimal>(type: "numeric", nullable: false),
                    ZoningInformation = table.Column<string>(type: "text", nullable: true),
                    PermitsRequired = table.Column<string>(type: "text", nullable: true),
                    TaxId = table.Column<string>(type: "text", nullable: true),
                    DeveloperName = table.Column<string>(type: "text", nullable: true),
                    ProjectName = table.Column<string>(type: "text", nullable: true),
                    ExclusiveFeatures = table.Column<string>(type: "text", nullable: true),
                    TermsOfAgreement = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Properties_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalSchema: "app",
                        principalTable: "Projects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PaymentPlanFees",
                schema: "app",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    AmountOrRate = table.Column<decimal>(type: "numeric", nullable: false),
                    IsRecurring = table.Column<bool>(type: "boolean", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    MilestoneId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentPlanFees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentPlanFees_PaymentPlanMilestones_MilestoneId",
                        column: x => x.MilestoneId,
                        principalSchema: "app",
                        principalTable: "PaymentPlanMilestones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                schema: "app",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    PropertyId = table.Column<string>(type: "text", nullable: true),
                    CustomerId = table.Column<string>(type: "text", nullable: true),
                    AgentId = table.Column<string>(type: "text", nullable: true),
                    BookingDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    BookingStatus = table.Column<string>(type: "text", nullable: true),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "numeric", nullable: false),
                    AmountPaid = table.Column<decimal>(type: "numeric", nullable: false),
                    PaymentStatus = table.Column<string>(type: "text", nullable: true),
                    PaymentMethod = table.Column<string>(type: "text", nullable: true),
                    CustomerName = table.Column<string>(type: "text", nullable: true),
                    CustomerEmail = table.Column<string>(type: "text", nullable: true),
                    CustomerPhone = table.Column<string>(type: "text", nullable: true),
                    Notes = table.Column<string>(type: "text", nullable: true),
                    IsRefundable = table.Column<bool>(type: "boolean", nullable: false),
                    PaymentPlanId = table.Column<string>(type: "text", nullable: true),
                    Installments = table.Column<Dictionary<int, BookingMilestone>>(type: "jsonb", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_PaymentPlans_PaymentPlanId",
                        column: x => x.PaymentPlanId,
                        principalSchema: "app",
                        principalTable: "PaymentPlans",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookings_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalSchema: "app",
                        principalTable: "Properties",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookings_Users_AgentId",
                        column: x => x.AgentId,
                        principalSchema: "admin",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookings_Users_CustomerId",
                        column: x => x.CustomerId,
                        principalSchema: "admin",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Rental",
                schema: "app",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    PropertyId = table.Column<string>(type: "text", nullable: false),
                    CheckIn = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CheckOut = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsAvailable = table.Column<bool>(type: "boolean", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    BookingId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rental", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rental_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalSchema: "app",
                        principalTable: "Bookings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Rental_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalSchema: "app",
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_AgentId",
                schema: "app",
                table: "Bookings",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CustomerId",
                schema: "app",
                table: "Bookings",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_PaymentPlanId",
                schema: "app",
                table: "Bookings",
                column: "PaymentPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_PropertyId",
                schema: "app",
                table: "Bookings",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentPlanFees_MilestoneId",
                schema: "app",
                table: "PaymentPlanFees",
                column: "MilestoneId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentPlanMilestones_PaymentPlanId",
                schema: "app",
                table: "PaymentPlanMilestones",
                column: "PaymentPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPaymentPlans_PaymentPlanId",
                schema: "app",
                table: "ProjectPaymentPlans",
                column: "PaymentPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPaymentPlans_ProjectId_PaymentPlanId",
                schema: "app",
                table: "ProjectPaymentPlans",
                columns: new[] { "ProjectId", "PaymentPlanId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Properties_ProjectId",
                schema: "app",
                table: "Properties",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Rental_BookingId",
                schema: "app",
                table: "Rental",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Rental_PropertyId",
                schema: "app",
                table: "Rental",
                column: "PropertyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentPlanFees",
                schema: "app");

            migrationBuilder.DropTable(
                name: "ProjectPaymentPlans",
                schema: "app");

            migrationBuilder.DropTable(
                name: "Rental",
                schema: "app");

            migrationBuilder.DropTable(
                name: "PaymentPlanMilestones",
                schema: "app");

            migrationBuilder.DropTable(
                name: "Bookings",
                schema: "app");

            migrationBuilder.DropTable(
                name: "PaymentPlans",
                schema: "app");

            migrationBuilder.DropTable(
                name: "Properties",
                schema: "app");

            migrationBuilder.DropTable(
                name: "Projects",
                schema: "app");

            migrationBuilder.UpdateData(
                schema: "admin",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "530b21d4-4dd9-4749-9444-ee1384d37d38",
                column: "ConcurrencyStamp",
                value: "e21423d9-7306-43cd-a20b-19e76b0652bc");

            migrationBuilder.UpdateData(
                schema: "admin",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "7db8bdb6-8ffe-4f73-903f-fe0424d52e10",
                column: "ConcurrencyStamp",
                value: "d7c44bbd-0de6-44bb-b6db-72b9cf518e97");

            migrationBuilder.UpdateData(
                schema: "admin",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c79c336b-5210-411e-b8c5-f6f210d06204",
                column: "ConcurrencyStamp",
                value: "3b76cca3-58e3-460f-823d-f24aeb7768a3");

            migrationBuilder.UpdateData(
                schema: "admin",
                table: "Users",
                keyColumn: "Id",
                keyValue: "52f9a82a-e4b6-4f67-ae91-2e173aa21a1a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7ab75e6-6739-4a6b-83cc-d051c98311ec", "AQAAAAIAAYagAAAAEGDbWtSRHcPaBG+tFuEl0OSJWa0uYL/SpCKGUjeYnkb//b+v66mOvH/6LSHQgMyPRw==", "ccd990a2-48b5-4f84-90a5-12798f993153" });

            migrationBuilder.UpdateData(
                schema: "admin",
                table: "Users",
                keyColumn: "Id",
                keyValue: "a901fdf4-edcb-4b6d-9a65-40df5b062f24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50db3cc5-8fd5-4af0-b761-7d1386fdf2ff", "AQAAAAIAAYagAAAAEGcMNQf4L8FVZbuKL/L6e2AM4KgtcVohCC4ZYTVovnKTf6hL8Gbgde9rcYVYgJHyuQ==", "b895c013-ac68-4608-92cf-0d8a4b39ca26" });

            migrationBuilder.UpdateData(
                schema: "admin",
                table: "Users",
                keyColumn: "Id",
                keyValue: "e63a9b1c-2f89-406e-a5dc-d6ebe5cdf05a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d49e8973-4f21-4986-bf57-44a1aa9a834e", "AQAAAAIAAYagAAAAEM1mD+4HXJsWygaeWg8YFgkXTWHJNeByKMpv23H9gxX3mMR4SUJkpacYmJuPNU8V3w==", "03c4f97f-14dd-4b52-947b-3d8cf14c07a3" });
        }
    }
}
