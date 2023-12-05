using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "77fd03d3-1692-4c96-8024-d789cbd0df2d", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAENQDWGOjiEIPN5WGQ8JyZOhs1AeJuR6S4UTc195xfHWCn8PAffuP8iFZVWkEAPWPPw==", null, false, "b02fbd66-6abe-4ba9-83de-3b0427ccaa30", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 12, 5, 19, 58, 6, 751, DateTimeKind.Local).AddTicks(6959), new DateTime(2023, 12, 5, 19, 58, 6, 751, DateTimeKind.Local).AddTicks(6975), "Black", "System" },
                    { 2, "System", new DateTime(2023, 12, 5, 19, 58, 6, 751, DateTimeKind.Local).AddTicks(6980), new DateTime(2023, 12, 5, 19, 58, 6, 751, DateTimeKind.Local).AddTicks(6981), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 12, 5, 19, 58, 6, 751, DateTimeKind.Local).AddTicks(7378), new DateTime(2023, 12, 5, 19, 58, 6, 751, DateTimeKind.Local).AddTicks(7379), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 12, 5, 19, 58, 6, 751, DateTimeKind.Local).AddTicks(7381), new DateTime(2023, 12, 5, 19, 58, 6, 751, DateTimeKind.Local).AddTicks(7382), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 12, 5, 19, 58, 6, 751, DateTimeKind.Local).AddTicks(7607), new DateTime(2023, 12, 5, 19, 58, 6, 751, DateTimeKind.Local).AddTicks(7609), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 12, 5, 19, 58, 6, 751, DateTimeKind.Local).AddTicks(7611), new DateTime(2023, 12, 5, 19, 58, 6, 751, DateTimeKind.Local).AddTicks(7611), "X5", "System" },
                    { 3, "System", new DateTime(2023, 12, 5, 19, 58, 6, 751, DateTimeKind.Local).AddTicks(7613), new DateTime(2023, 12, 5, 19, 58, 6, 751, DateTimeKind.Local).AddTicks(7614), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 12, 5, 19, 58, 6, 751, DateTimeKind.Local).AddTicks(7616), new DateTime(2023, 12, 5, 19, 58, 6, 751, DateTimeKind.Local).AddTicks(7617), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
