using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAppEBOS.Entity.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RefAppId = table.Column<int>(type: "int", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Value });
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Created", "Name", "Path", "RefAppId", "Status", "Updated" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1876), "John", null, 1, 1, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1878) },
                    { 2, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1886), "Emily", null, 2, 1, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1886) },
                    { 3, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1887), "Michael", null, 3, 1, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1888) },
                    { 4, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1889), "Sophia", null, 9, 1, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1889) },
                    { 5, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1890), "William", null, 5, 1, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1890) },
                    { 7, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1893), "Olivia", null, 2, 1, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1893) },
                    { 8, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1894), "Liam", null, 10, 1, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1894) },
                    { 9, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1895), "Ava", null, 15, 1, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1895) },
                    { 10, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1897), "Noah", null, 8, 1, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1898) },
                    { 11, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1899), "Isabella", null, 4, 1, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1899) },
                    { 12, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1900), "James", null, 1, 1, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1901) },
                    { 13, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1902), "Emma", null, 6, 1, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1902) },
                    { 14, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1903), "Benjamin", null, 11, 1, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1903) },
                    { 15, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1904), "Mia", null, 14, 1, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1904) },
                    { 16, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1908), "Ethan", null, 13, 1, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1909) },
                    { 17, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1910), "Charlotte", null, 3, 1, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1910) },
                    { 18, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1911), "Alexander", null, 5, 1, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1912) },
                    { 19, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1913), "Amelia", null, 9, 1, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1913) },
                    { 20, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1914), "Daniel", null, 7, 1, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1915) },
                    { 21, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1916), "Harper", null, 10, 1, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1916) },
                    { 22, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1917), "Matthew", null, 2, 1, new DateTime(2023, 8, 18, 13, 1, 39, 600, DateTimeKind.Utc).AddTicks(1918) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserTokens");
        }
    }
}
