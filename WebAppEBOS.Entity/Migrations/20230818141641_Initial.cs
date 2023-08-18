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
                name: "Calls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CallerId = table.Column<int>(type: "int", nullable: true),
                    ReceiverId = table.Column<int>(type: "int", nullable: true),
                    CallerPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceiverPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DurationInSeconds = table.Column<int>(type: "int", nullable: false),
                    CallStatus = table.Column<int>(type: "int", nullable: false),
                    CallRating = table.Column<int>(type: "int", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    CallDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TelephoneHomeNumber = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TelephonePhoneNumber = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TelephoneWorkNumber = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PostCode = table.Column<int>(type: "int", nullable: false),
                    DateBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                table: "Calls",
                columns: new[] { "Id", "CallDateTime", "CallRating", "CallStatus", "CallerId", "CallerPhoneNumber", "Created", "Description", "DurationInSeconds", "IsArchived", "ReceiverId", "ReceiverPhoneNumber", "StartTime", "Status", "Subject", "Updated" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 18, 16, 46, 41, 27, DateTimeKind.Local).AddTicks(2750), 4, 2, 1, "123-456-7890", new DateTime(2023, 8, 18, 14, 16, 41, 27, DateTimeKind.Utc).AddTicks(2697), "Discuss project status", 1800, false, 2, "987-654-3210", new DateTime(2023, 8, 18, 16, 46, 41, 27, DateTimeKind.Local).AddTicks(2704), 1, "Meeting", new DateTime(2023, 8, 18, 14, 16, 41, 27, DateTimeKind.Utc).AddTicks(2699) },
                    { 2, new DateTime(2023, 8, 18, 15, 16, 41, 27, DateTimeKind.Local).AddTicks(2761), 3, 1, 3, "555-123-4567", new DateTime(2023, 8, 18, 14, 16, 41, 27, DateTimeKind.Utc).AddTicks(2756), "Planning session", 2700, true, 4, "555-987-6543", new DateTime(2023, 8, 18, 15, 16, 41, 27, DateTimeKind.Local).AddTicks(2757), 1, "Conference Call", new DateTime(2023, 8, 18, 14, 16, 41, 27, DateTimeKind.Utc).AddTicks(2756) },
                    { 3, new DateTime(2023, 8, 18, 12, 16, 41, 27, DateTimeKind.Local).AddTicks(2766), 2, 2, 6, "111-222-3333", new DateTime(2023, 8, 18, 14, 16, 41, 27, DateTimeKind.Utc).AddTicks(2763), "Technical assistance", 1200, false, 7, "444-555-6666", new DateTime(2023, 8, 18, 12, 16, 41, 27, DateTimeKind.Local).AddTicks(2764), 1, "Support Call", new DateTime(2023, 8, 18, 14, 16, 41, 27, DateTimeKind.Utc).AddTicks(2763) },
                    { 4, new DateTime(2023, 8, 18, 7, 16, 41, 27, DateTimeKind.Local).AddTicks(2772), 4, 1, 8, "999-888-7777", new DateTime(2023, 8, 18, 14, 16, 41, 27, DateTimeKind.Utc).AddTicks(2768), "Product presentation", 1500, true, 9, "777-888-9999", new DateTime(2023, 8, 18, 7, 16, 41, 27, DateTimeKind.Local).AddTicks(2769), 1, "Sales Call", new DateTime(2023, 8, 18, 14, 16, 41, 27, DateTimeKind.Utc).AddTicks(2768) },
                    { 5, new DateTime(2023, 8, 18, 16, 46, 41, 27, DateTimeKind.Local).AddTicks(2776), 4, 2, 1, "123-456-7890", new DateTime(2023, 8, 18, 14, 16, 41, 27, DateTimeKind.Utc).AddTicks(2773), "Discuss project status", 1800, false, 2, "987-654-3210", new DateTime(2023, 8, 18, 16, 46, 41, 27, DateTimeKind.Local).AddTicks(2774), 1, "Meeting", new DateTime(2023, 8, 18, 14, 16, 41, 27, DateTimeKind.Utc).AddTicks(2773) },
                    { 6, new DateTime(2023, 8, 18, 15, 16, 41, 27, DateTimeKind.Local).AddTicks(2781), 3, 1, 3, "555-123-4567", new DateTime(2023, 8, 18, 14, 16, 41, 27, DateTimeKind.Utc).AddTicks(2779), "Planning session", 2700, true, 4, "555-987-6543", new DateTime(2023, 8, 18, 15, 16, 41, 27, DateTimeKind.Local).AddTicks(2780), 1, "Conference Call", new DateTime(2023, 8, 18, 14, 16, 41, 27, DateTimeKind.Utc).AddTicks(2779) },
                    { 7, new DateTime(2023, 8, 18, 12, 16, 41, 27, DateTimeKind.Local).AddTicks(2785), 2, 2, 6, "111-222-3333", new DateTime(2023, 8, 18, 14, 16, 41, 27, DateTimeKind.Utc).AddTicks(2783), "Technical assistance", 1200, false, 7, "444-555-6666", new DateTime(2023, 8, 18, 12, 16, 41, 27, DateTimeKind.Local).AddTicks(2784), 1, "Support Call", new DateTime(2023, 8, 18, 14, 16, 41, 27, DateTimeKind.Utc).AddTicks(2783) },
                    { 8, new DateTime(2023, 8, 18, 7, 16, 41, 27, DateTimeKind.Local).AddTicks(2789), 4, 1, 8, "999-888-7777", new DateTime(2023, 8, 18, 14, 16, 41, 27, DateTimeKind.Utc).AddTicks(2787), "Product presentation", 1500, true, 9, "777-888-9999", new DateTime(2023, 8, 18, 7, 16, 41, 27, DateTimeKind.Local).AddTicks(2788), 1, "Sales Call", new DateTime(2023, 8, 18, 14, 16, 41, 27, DateTimeKind.Utc).AddTicks(2787) },
                    { 9, new DateTime(2023, 8, 18, 2, 16, 41, 27, DateTimeKind.Local).AddTicks(2793), 3, 2, 10, "123-987-6543", new DateTime(2023, 8, 18, 14, 16, 41, 27, DateTimeKind.Utc).AddTicks(2791), "Customer satisfaction survey", 900, false, 11, "555-123-4567", new DateTime(2023, 8, 18, 2, 16, 41, 27, DateTimeKind.Local).AddTicks(2792), 1, "Feedback Call", new DateTime(2023, 8, 18, 14, 16, 41, 27, DateTimeKind.Utc).AddTicks(2791) },
                    { 10, new DateTime(2023, 8, 17, 21, 16, 41, 27, DateTimeKind.Local).AddTicks(2798), 2, 1, 12, "777-555-8888", new DateTime(2023, 8, 18, 14, 16, 41, 27, DateTimeKind.Utc).AddTicks(2795), "Promotion details", 1800, true, 13, "222-444-6666", new DateTime(2023, 8, 17, 21, 16, 41, 27, DateTimeKind.Local).AddTicks(2796), 1, "Marketing Call", new DateTime(2023, 8, 18, 14, 16, 41, 27, DateTimeKind.Utc).AddTicks(2795) }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "Country", "Created", "DateBirth", "Name", "Path", "PostCode", "RefAppId", "Status", "Surname", "TelephoneHomeNumber", "TelephonePhoneNumber", "TelephoneWorkNumber", "Updated" },
                values: new object[,]
                {
                    { 1, "123 Main St", "USA", new DateTime(2023, 8, 18, 14, 16, 41, 27, DateTimeKind.Utc).AddTicks(4578), new DateTime(1985, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "path/to/file1", 12345, 1, 1, "Doe", "123-456-7890", "987-654-3210", "555-123-4567", new DateTime(2023, 8, 18, 14, 16, 41, 27, DateTimeKind.Utc).AddTicks(4579) },
                    { 2, "456 Elm St", "Canada", new DateTime(2023, 8, 18, 14, 16, 41, 27, DateTimeKind.Utc).AddTicks(4588), new DateTime(1990, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emily", "path/to/file2", 56789, 2, 1, "Smith", "555-789-1234", "444-321-5678", "777-555-8888", new DateTime(2023, 8, 18, 14, 16, 41, 27, DateTimeKind.Utc).AddTicks(4588) },
                    { 3, "789 Oak St", "USA", new DateTime(2023, 8, 18, 14, 16, 41, 27, DateTimeKind.Utc).AddTicks(4591), new DateTime(1992, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jessica", "path/to/file3", 67890, 3, 1, "Johnson", "777-111-2222", "888-333-4444", "555-666-7777", new DateTime(2023, 8, 18, 14, 16, 41, 27, DateTimeKind.Utc).AddTicks(4591) },
                    { 4, "567 Maple St", "USA", new DateTime(2023, 8, 18, 14, 16, 41, 27, DateTimeKind.Utc).AddTicks(4593), new DateTime(1988, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniel", "path/to/file4", 34567, 4, 1, "Williams", "999-444-5555", "222-555-6666", "333-666-7777", new DateTime(2023, 8, 18, 14, 16, 41, 27, DateTimeKind.Utc).AddTicks(4593) },
                    { 5, "101 Pine St", "USA", new DateTime(2023, 8, 18, 14, 16, 41, 27, DateTimeKind.Utc).AddTicks(4621), new DateTime(1993, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sophia", "path/to/file5", 12345, 5, 1, "Brown", "111-222-3333", "444-555-6666", "777-888-9999", new DateTime(2023, 8, 18, 14, 16, 41, 27, DateTimeKind.Utc).AddTicks(4621) },
                    { 6, "202 Oak St", "USA", new DateTime(2023, 8, 18, 14, 16, 41, 27, DateTimeKind.Utc).AddTicks(4625), new DateTime(1991, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ethan", "path/to/file6", 67890, 6, 1, "Taylor", "555-777-8888", "222-444-5555", "111-888-9999", new DateTime(2023, 8, 18, 14, 16, 41, 27, DateTimeKind.Utc).AddTicks(4625) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calls");

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
