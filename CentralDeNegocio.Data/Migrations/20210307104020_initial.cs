using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CentralDeNegocio.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    Email = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false),
                    Password = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    MobileNumber = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    PhoneNumber = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 3, 7, 7, 40, 19, 453, DateTimeKind.Local).AddTicks(5796)),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Email", "FullName", "MobileNumber", "Password", "PhoneNumber" },
                values: new object[] { new Guid("7776fec6-6253-497f-a099-7d90b86d92a2"), new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "userdefault@centraldenegocio.com.br", "User Default", "16991670698", "Abc123456", null });

            migrationBuilder.CreateIndex(
                name: "IX_Client_Email",
                table: "Client",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Client_FullName",
                table: "Client",
                column: "FullName");

            migrationBuilder.CreateIndex(
                name: "IX_Client_MobileNumber",
                table: "Client",
                column: "MobileNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
