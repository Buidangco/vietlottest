using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VietLotApi.Migrations
{
    /// <inheritdoc />
    public partial class AddOffices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Department",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "OfficeId",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Offices",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ManagerId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offices", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Id", "Code", "CreatedAt", "ManagerId", "Name", "Status", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { "O001", "BGD", new DateTime(2026, 6, 3, 8, 46, 2, 345, DateTimeKind.Utc).AddTicks(5446), null, "Ban Giam Doc", "ACTIVE", "DEPARTMENT", new DateTime(2026, 6, 3, 8, 46, 2, 345, DateTimeKind.Utc).AddTicks(5447) },
                    { "O002", "PTV", new DateTime(2026, 6, 3, 8, 46, 2, 345, DateTimeKind.Utc).AddTicks(5454), null, "Phong Tai vu", "ACTIVE", "DEPARTMENT", new DateTime(2026, 6, 3, 8, 46, 2, 345, DateTimeKind.Utc).AddTicks(5455) },
                    { "O003", "CN_HCM", new DateTime(2026, 6, 3, 8, 46, 2, 345, DateTimeKind.Utc).AddTicks(5458), null, "Chi nhanh TP.HCM", "ACTIVE", "BRANCH", new DateTime(2026, 6, 3, 8, 46, 2, 345, DateTimeKind.Utc).AddTicks(5459) }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "G001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 3, 8, 46, 2, 345, DateTimeKind.Utc).AddTicks(5061), new DateTime(2026, 6, 3, 8, 46, 2, 345, DateTimeKind.Utc).AddTicks(5066) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "G002",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 3, 8, 46, 2, 345, DateTimeKind.Utc).AddTicks(5074), new DateTime(2026, 6, 3, 8, 46, 2, 345, DateTimeKind.Utc).AddTicks(5075) });

            migrationBuilder.CreateIndex(
                name: "IX_Users_OfficeId",
                table: "Users",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Offices_Code",
                table: "Offices",
                column: "Code",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Offices_OfficeId",
                table: "Users",
                column: "OfficeId",
                principalTable: "Offices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Offices_OfficeId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Offices");

            migrationBuilder.DropIndex(
                name: "IX_Users_OfficeId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "OfficeId",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "G001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 3, 4, 4, 5, 371, DateTimeKind.Utc).AddTicks(2743), new DateTime(2026, 6, 3, 4, 4, 5, 371, DateTimeKind.Utc).AddTicks(2747) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "G002",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 3, 4, 4, 5, 371, DateTimeKind.Utc).AddTicks(2760), new DateTime(2026, 6, 3, 4, 4, 5, 371, DateTimeKind.Utc).AddTicks(2761) });
        }
    }
}
