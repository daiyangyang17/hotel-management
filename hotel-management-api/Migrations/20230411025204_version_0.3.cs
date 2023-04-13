using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hotel_management_api.Migrations
{
    public partial class version_03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 2, 52, 3, 915, DateTimeKind.Utc).AddTicks(202));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 2, 52, 3, 915, DateTimeKind.Utc).AddTicks(204));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 2, 52, 3, 915, DateTimeKind.Utc).AddTicks(206));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 2, 52, 3, 915, DateTimeKind.Utc).AddTicks(207));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 2, 52, 3, 915, DateTimeKind.Utc).AddTicks(237));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 2, 52, 3, 915, DateTimeKind.Utc).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 2, 52, 3, 915, DateTimeKind.Utc).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 2, 52, 3, 915, DateTimeKind.Utc).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 2, 52, 3, 915, DateTimeKind.Utc).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Role" },
                values: new object[] { new DateTime(2023, 4, 11, 2, 52, 3, 915, DateTimeKind.Utc).AddTicks(10), "Manager" });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "Address", "CreatedDate", "Email", "Name", "NumberPhone", "Password", "Role", "UpdatedDate", "Username" },
                values: new object[,]
                {
                    { 2, "Hà Nội", new DateTime(2023, 4, 11, 2, 52, 3, 915, DateTimeKind.Utc).AddTicks(150), "nguyenthib@gmail.com", "Nguyễn Thị B", "0123456788", "FF9AA1E68A37C1F87F9BE3B91860726A", "Accountant", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenthib@gmail.com" },
                    { 3, "Hà Nội", new DateTime(2023, 4, 11, 2, 52, 3, 915, DateTimeKind.Utc).AddTicks(166), "nguyenthib@gmail.com", "Nguyễn Thị B", "0123456788", "FF9AA1E68A37C1F87F9BE3B91860726A", "Receptionist", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenthib@gmail.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 10, 15, 23, 39, 688, DateTimeKind.Utc).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 10, 15, 23, 39, 688, DateTimeKind.Utc).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 10, 15, 23, 39, 688, DateTimeKind.Utc).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 10, 15, 23, 39, 688, DateTimeKind.Utc).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 10, 15, 23, 39, 688, DateTimeKind.Utc).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 10, 15, 23, 39, 688, DateTimeKind.Utc).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 10, 15, 23, 39, 688, DateTimeKind.Utc).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 10, 15, 23, 39, 688, DateTimeKind.Utc).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "hotel_rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 10, 15, 23, 39, 688, DateTimeKind.Utc).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Role" },
                values: new object[] { new DateTime(2023, 4, 10, 15, 23, 39, 688, DateTimeKind.Utc).AddTicks(7703), "User" });
        }
    }
}
