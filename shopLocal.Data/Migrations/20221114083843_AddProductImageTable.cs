using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace shopLocal.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<decimal>(
                name: "OriginalPrice",
                table: "ProductTranslations",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "ProductTranslations",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Stock",
                table: "ProductTranslations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ViewCount",
                table: "ProductTranslations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 9, 17, 7, 8, 541, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    FileSize = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

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

            migrationBuilder.DropColumn(
                name: "OriginalPrice",
                table: "ProductTranslations");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "ProductTranslations");

            migrationBuilder.DropColumn(
                name: "Stock",
                table: "ProductTranslations");

            migrationBuilder.DropColumn(
                name: "ViewCount",
                table: "ProductTranslations");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 9, 17, 7, 8, 541, DateTimeKind.Local).AddTicks(8281),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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
    }
}
