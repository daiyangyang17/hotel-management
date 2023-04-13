using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hotel_management_api.Migrations
{
    public partial class version_02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    HotelRoomId = table.Column<int>(type: "int", nullable: false),
                    ReservationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CheckinTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CheckoutTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    TotalPrice = table.Column<double>(type: "double", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookings", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateOfBirth = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Address = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumberPhone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Accumulation = table.Column<int>(type: "int", nullable: false),
                    NumberBooking = table.Column<int>(type: "int", nullable: false),
                    CustomerType = table.Column<byte>(type: "tinyint unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "hotel_rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NoRoom = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Floor = table.Column<int>(type: "int", nullable: false),
                    RoomType = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    NumberBed = table.Column<int>(type: "int", nullable: false),
                    Area = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<double>(type: "double", nullable: false),
                    RoomStatus = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    Option = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Image = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hotel_rooms", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "hotel_rooms",
                columns: new[] { "Id", "Area", "CreatedDate", "Description", "Floor", "Image", "NoRoom", "NumberBed", "Option", "Price", "RoomStatus", "RoomType", "Size", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 28, new DateTime(2023, 4, 10, 15, 23, 39, 688, DateTimeKind.Utc).AddTicks(8208), "", 2, "", "201", 1, "", 3000000.0, (byte)2, (byte)0, "7mx4m", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 40, new DateTime(2023, 4, 10, 15, 23, 39, 688, DateTimeKind.Utc).AddTicks(8242), "", 2, "", "202", 2, "", 5000000.0, (byte)2, (byte)1, "8mx5m", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 35, new DateTime(2023, 4, 10, 15, 23, 39, 688, DateTimeKind.Utc).AddTicks(8244), "", 2, "", "203", 1, "", 3000000.0, (byte)2, (byte)2, "7mx5m", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 28, new DateTime(2023, 4, 10, 15, 23, 39, 688, DateTimeKind.Utc).AddTicks(8245), "", 3, "", "301", 1, "", 3000000.0, (byte)2, (byte)0, "7mx4m", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 40, new DateTime(2023, 4, 10, 15, 23, 39, 688, DateTimeKind.Utc).AddTicks(8246), "", 3, "", "302", 2, "", 5000000.0, (byte)2, (byte)1, "8mx5m", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 35, new DateTime(2023, 4, 10, 15, 23, 39, 688, DateTimeKind.Utc).AddTicks(8247), "", 3, "", "303", 1, "", 3000000.0, (byte)2, (byte)2, "7mx5m", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 28, new DateTime(2023, 4, 10, 15, 23, 39, 688, DateTimeKind.Utc).AddTicks(8248), "", 4, "", "401", 1, "", 3000000.0, (byte)2, (byte)0, "7mx4m", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 40, new DateTime(2023, 4, 10, 15, 23, 39, 688, DateTimeKind.Utc).AddTicks(8249), "", 4, "", "402", 2, "", 5000000.0, (byte)2, (byte)1, "8mx5m", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 35, new DateTime(2023, 4, 10, 15, 23, 39, 688, DateTimeKind.Utc).AddTicks(8250), "", 4, "", "403", 1, "", 3000000.0, (byte)2, (byte)2, "7mx5m", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 10, 15, 23, 39, 688, DateTimeKind.Utc).AddTicks(7703));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bookings");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "hotel_rooms");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 10, 8, 11, 45, 462, DateTimeKind.Utc).AddTicks(1193));
        }
    }
}
