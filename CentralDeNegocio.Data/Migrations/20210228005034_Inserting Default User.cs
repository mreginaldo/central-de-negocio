using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CentralDeNegocio.Data.Migrations
{
    public partial class InsertingDefaultUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { new Guid("7776fec6-6253-497f-a099-7d90b86d92a2"), "userdefault@centraldenegocio.com.br", "User Default" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7776fec6-6253-497f-a099-7d90b86d92a2"));
        }
    }
}
