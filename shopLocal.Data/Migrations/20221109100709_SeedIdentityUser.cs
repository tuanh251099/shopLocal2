using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace shopLocal.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 17, 7, 8, 541, DateTimeKind.Local).AddTicks(8281),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 16, 26, 24, 642, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("0d410fd9-a1e9-4b52-9a9c-4accf8132473"), "65d4cb8b-804f-4409-9650-e956349c1084", "Adminnistrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("0d410fd9-a1e9-4b52-9a9c-4accf8132473"), new Guid("78bde05a-0a88-4a2e-a915-7646c4d8d4b9") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("78bde05a-0a88-4a2e-a915-7646c4d8d4b9"), 0, "881d4285-ce21-44cc-95f6-e6f58c4e2afa", new DateTime(1999, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "tuanh.99.2510@gmail.com", true, "Tuan", "Anh", false, null, "ta25@gmial.com", "admin", "AQAAAAEAACcQAAAAEO/kO7xsCxGCSRf12p8jVboo2hlc9BiJCF11ZtOj+cmzxhyqXK3FDQTUXWHkF2h5Og==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 11, 9, 17, 7, 8, 544, DateTimeKind.Local).AddTicks(3843));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("0d410fd9-a1e9-4b52-9a9c-4accf8132473"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0d410fd9-a1e9-4b52-9a9c-4accf8132473"), new Guid("78bde05a-0a88-4a2e-a915-7646c4d8d4b9") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("78bde05a-0a88-4a2e-a915-7646c4d8d4b9"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 16, 26, 24, 642, DateTimeKind.Local).AddTicks(6659),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 17, 7, 8, 541, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 11, 9, 16, 26, 24, 644, DateTimeKind.Local).AddTicks(9361));
        }
    }
}
