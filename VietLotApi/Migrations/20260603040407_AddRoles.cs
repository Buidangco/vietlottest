using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VietLotApi.Migrations
{
    /// <inheritdoc />
    public partial class AddRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Role",
                table: "Users",
                newName: "RoleId");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ColorCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RolePermissions",
                columns: table => new
                {
                    RoleId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PermissionCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermissions", x => new { x.RoleId, x.PermissionCode });
                    table.ForeignKey(
                        name: "FK_RolePermissions_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ColorCode", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "G001", "#7c3aed", new DateTime(2026, 6, 3, 4, 4, 5, 371, DateTimeKind.Utc).AddTicks(2743), "Toan quyen he thong", "Admin (Giam doc)", new DateTime(2026, 6, 3, 4, 4, 5, 371, DateTimeKind.Utc).AddTicks(2747) },
                    { "G002", "#1d4ed8", new DateTime(2026, 6, 3, 4, 4, 5, 371, DateTimeKind.Utc).AddTicks(2760), "Chi tra, hach toan", "Nhan vien Ke toan", new DateTime(2026, 6, 3, 4, 4, 5, 371, DateTimeKind.Utc).AddTicks(2761) }
                });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "PermissionCode", "RoleId" },
                values: new object[,]
                {
                    { "baocao", "G001" },
                    { "congkhach", "G001" },
                    { "daily", "G001" },
                    { "dashboard", "G001" },
                    { "hethong", "G001" },
                    { "ketoan", "G001" },
                    { "nhatky", "G001" },
                    { "phathanh", "G001" },
                    { "thamdinh", "G001" },
                    { "thuhoi", "G001" },
                    { "trathuong", "G001" },
                    { "baocao", "G002" },
                    { "dashboard", "G002" },
                    { "ketoan", "G002" },
                    { "nhatky", "G002" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "RolePermissions");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Users_RoleId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "Users",
                newName: "Role");
        }
    }
}
