using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web_project.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategorySex = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDecription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductPrice = table.Column<int>(type: "int", nullable: false),
                    ProductBrand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductProductCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDateUpload = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cart_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cart_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductInCategories",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInCategories", x => new { x.CategoryId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductInCategories_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "3ffb5434-e94d-45bf-b4a6-a96f0f4b2c70", "Administrator role", "admin", "admin" },
                    { new Guid("bf60bd9d-6c87-406b-b75e-8bcf13d1f2e8"), "d7f93d3a-4b9c-4ad8-8171-f0968bad8ce0", "staff role", "staff", "staff" }
                });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { new Guid("bf60bd9d-6c87-406b-b75e-8bcf13d1f2e8"), new Guid("d8128f3a-e0c7-4355-b0b4-40d339d9db55") }
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0, "ce2cf421-6f68-4855-8567-7987ad3154a7", new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "Ad", "min", false, null, "admin@gmail.com", "admin", "AQAAAAEAACcQAAAAEDY5IyXj7INF8SZf0vdSaS8qsVHcsY2YIasTxsuAiIjOVjUe8+AnK1lWIICrImdiDw==", null, false, "", false, "admin" },
                    { new Guid("d8128f3a-e0c7-4355-b0b4-40d339d9db55"), 0, "13d0a500-7eab-47fd-ab2a-f762f4512a04", new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff@gmail.com", true, "staff", "staff", false, null, "staff@gmail.com", "staff", "AQAAAAEAACcQAAAAEJMyKJeymDBesW/FNa9q5WTxUJ062t1ZRLJFqTogBQ1bzwSI3Jhld/3wPOUvHY89Dw==", null, false, "", false, "staff" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryName", "CategorySex", "CategoryType", "SortOrder" },
                values: new object[,]
                {
                    { 1, "CategoryName", "woman", "CategoryType", 1 },
                    { 2, "CategoryName", "man", "CategoryType", 1 },
                    { 3, "CategoryName", "bede", "CategoryType", 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductBrand", "ProductColor", "ProductDateUpload", "ProductDecription", "ProductName", "ProductPrice", "ProductProductCode", "ProductSize" },
                values: new object[,]
                {
                    { 8, "ProductBrand", "ProductColor", new DateTime(2021, 8, 14, 4, 10, 44, 212, DateTimeKind.Local).AddTicks(7945), "ProductDecription", "ProductName8", 11, "ProductProductCode", "ProductSize" },
                    { 7, "ProductBrand", "ProductColor", new DateTime(2021, 8, 14, 4, 10, 44, 212, DateTimeKind.Local).AddTicks(7944), "ProductDecription", "ProductName7", 11, "ProductProductCode", "ProductSize" },
                    { 6, "ProductBrand", "ProductColor", new DateTime(2021, 8, 14, 4, 10, 44, 212, DateTimeKind.Local).AddTicks(7942), "ProductDecription", "ProductName6", 11, "ProductProductCode", "ProductSize" },
                    { 5, "ProductBrand", "ProductColor", new DateTime(2021, 8, 14, 4, 10, 44, 212, DateTimeKind.Local).AddTicks(7941), "ProductDecription", "ProductName5", 11, "ProductProductCode", "ProductSize" },
                    { 1, "ProductBrand", "ProductColor", new DateTime(2021, 8, 14, 4, 10, 44, 212, DateTimeKind.Local).AddTicks(4462), "ProductDecription", "ProductName1", 11, "ProductProductCode", "ProductSize" },
                    { 3, "ProductBrand", "ProductColor", new DateTime(2021, 8, 14, 4, 10, 44, 212, DateTimeKind.Local).AddTicks(7937), "ProductDecription", "ProductName3", 11, "ProductProductCode", "ProductSize" },
                    { 2, "ProductBrand", "ProductColor", new DateTime(2021, 8, 14, 4, 10, 44, 212, DateTimeKind.Local).AddTicks(7925), "ProductDecription", "ProductName2", 11, "ProductProductCode", "ProductSize" },
                    { 9, "ProductBrand", "ProductColor", new DateTime(2021, 8, 14, 4, 10, 44, 212, DateTimeKind.Local).AddTicks(7947), "ProductDecription", "ProductName9", 11, "ProductProductCode", "ProductSize" },
                    { 4, "ProductBrand", "ProductColor", new DateTime(2021, 8, 14, 4, 10, 44, 212, DateTimeKind.Local).AddTicks(7939), "ProductDecription", "ProductName4", 11, "ProductProductCode", "ProductSize" },
                    { 10, "ProductBrand", "ProductColor", new DateTime(2021, 8, 14, 4, 10, 44, 212, DateTimeKind.Local).AddTicks(7948), "ProductDecription", "ProductName10", 11, "ProductProductCode", "ProductSize" }
                });

            migrationBuilder.InsertData(
                table: "ProductInCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 1, 4 },
                    { 2, 5 },
                    { 3, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cart_AppUserId",
                table: "Cart",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_ProductId",
                table: "Cart",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInCategories_ProductId",
                table: "ProductInCategories",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppRoleClaims");

            migrationBuilder.DropTable(
                name: "AppRoles");

            migrationBuilder.DropTable(
                name: "AppUserClaims");

            migrationBuilder.DropTable(
                name: "AppUserLogins");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "AppUserTokens");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "ProductInCategories");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
