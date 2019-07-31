using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GMSAPI.Migrations
{
    public partial class UNandPwdAddedtoModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordHash",
                table: "MasterEmployees",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "MasterEmployees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "MasterEmployees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "MasterEmployees");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "MasterEmployees");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "MasterEmployees");
        }
    }
}
