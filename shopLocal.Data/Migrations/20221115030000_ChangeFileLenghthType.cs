using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace shopLocal.Data.Migrations
{
    public partial class ChangeFileLenghthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("9f182239-8e4c-4eba-90ee-9b129e5ca3dc"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("9f182239-8e4c-4eba-90ee-9b129e5ca3dc"), new Guid("3e7f4e60-7995-453b-8703-aa795de1e5ff") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("3e7f4e60-7995-453b-8703-aa795de1e5ff"));

            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("5f8a3e5e-3d1f-405d-abdf-a418392d70fb"), "7bbf5759-4869-4bd9-9bfb-5046057f1ede", "Adminnistrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("5f8a3e5e-3d1f-405d-abdf-a418392d70fb"), new Guid("1c0a1bdc-f283-417b-830a-160cd4c4551b") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("1c0a1bdc-f283-417b-830a-160cd4c4551b"), 0, "c85b08a2-7fbb-4b7d-a745-1cddee034080", new DateTime(1999, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "tuanh.99.2510@gmail.com", true, "Tuan", "Anh", false, null, "ta25@gmial.com", "admin", "AQAAAAEAACcQAAAAEAgynJwVUK+7NMLoEZjWFqN4CGuwVwpH6sTTGfST1l8ib5XjVwoVF+cNhhNkZniGww==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 11, 15, 9, 59, 59, 269, DateTimeKind.Local).AddTicks(6979));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("5f8a3e5e-3d1f-405d-abdf-a418392d70fb"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5f8a3e5e-3d1f-405d-abdf-a418392d70fb"), new Guid("1c0a1bdc-f283-417b-830a-160cd4c4551b") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1c0a1bdc-f283-417b-830a-160cd4c4551b"));

            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("9f182239-8e4c-4eba-90ee-9b129e5ca3dc"), "65440d1e-78bf-4d19-8230-8812c31347d2", "Adminnistrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("9f182239-8e4c-4eba-90ee-9b129e5ca3dc"), new Guid("3e7f4e60-7995-453b-8703-aa795de1e5ff") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("3e7f4e60-7995-453b-8703-aa795de1e5ff"), 0, "613c412b-ac26-4d29-ae35-fb292697e2a3", new DateTime(1999, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "tuanh.99.2510@gmail.com", true, "Tuan", "Anh", false, null, "ta25@gmial.com", "admin", "AQAAAAEAACcQAAAAEOo0DaQm6xcjjx095OFtolbiBee7jHU3I3npIhz7oFBicbZji9caDNfswlvbU/5ZyQ==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 11, 14, 15, 38, 42, 843, DateTimeKind.Local).AddTicks(14));
        }
    }
}
