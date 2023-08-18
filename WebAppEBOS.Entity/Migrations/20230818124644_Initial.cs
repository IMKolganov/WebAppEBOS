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
                    { 1, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9475), "John", null, 1, 1, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9477) },
                    { 2, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9483), "Emily", null, 1, 1, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9483) },
                    { 3, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9485), "Michael", null, 1, 1, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9485) },
                    { 4, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9486), "Sophia", null, 1, 1, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9486) },
                    { 5, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9487), "William", null, 1, 1, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9487) },
                    { 7, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9490), "Olivia", null, 1, 1, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9490) },
                    { 8, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9491), "Liam", null, 1, 1, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9492) },
                    { 9, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9493), "Ava", null, 1, 1, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9493) },
                    { 10, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9494), "Noah", null, 1, 1, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9494) },
                    { 11, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9496), "Isabella", null, 1, 1, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9496) },
                    { 12, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9497), "James", null, 1, 1, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9497) },
                    { 13, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9498), "Emma", null, 1, 1, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9498) },
                    { 14, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9499), "Benjamin", null, 1, 1, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9499) },
                    { 15, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9500), "Mia", null, 1, 1, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9500) },
                    { 16, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9501), "Ethan", null, 1, 1, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9502) },
                    { 17, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9503), "Charlotte", null, 1, 1, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9503) },
                    { 18, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9505), "Alexander", null, 1, 1, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9505) },
                    { 19, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9507), "Amelia", null, 1, 1, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9507) },
                    { 20, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9508), "Daniel", null, 1, 1, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9508) },
                    { 21, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9509), "Harper", null, 1, 1, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9509) },
                    { 22, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9510), "Matthew", null, 1, 1, new DateTime(2023, 8, 18, 12, 46, 44, 556, DateTimeKind.Utc).AddTicks(9511) }
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
