using Microsoft.EntityFrameworkCore.Migrations;

namespace GMSAPI.Migrations
{
    public partial class EmployeeModelChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DeptID",
                table: "MasterEmployees",
                newName: "DepartmentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DepartmentID",
                table: "MasterEmployees",
                newName: "DeptID");
        }
    }
}
