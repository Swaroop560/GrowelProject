using Microsoft.EntityFrameworkCore.Migrations;

namespace GMSAPI.Migrations
{
    public partial class MasterModelChangedDepartmentAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MasterEmployees_DepartmentInfos_DepartmentInfoId",
                table: "MasterEmployees");

            migrationBuilder.DropIndex(
                name: "IX_MasterEmployees_DepartmentInfoId",
                table: "MasterEmployees");

            migrationBuilder.DropColumn(
                name: "DepartmentInfoId",
                table: "MasterEmployees");

            migrationBuilder.CreateIndex(
                name: "IX_MasterEmployees_DepartmentID",
                table: "MasterEmployees",
                column: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_MasterEmployees_DepartmentInfos_DepartmentID",
                table: "MasterEmployees",
                column: "DepartmentID",
                principalTable: "DepartmentInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MasterEmployees_DepartmentInfos_DepartmentID",
                table: "MasterEmployees");

            migrationBuilder.DropIndex(
                name: "IX_MasterEmployees_DepartmentID",
                table: "MasterEmployees");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentInfoId",
                table: "MasterEmployees",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MasterEmployees_DepartmentInfoId",
                table: "MasterEmployees",
                column: "DepartmentInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_MasterEmployees_DepartmentInfos_DepartmentInfoId",
                table: "MasterEmployees",
                column: "DepartmentInfoId",
                principalTable: "DepartmentInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
