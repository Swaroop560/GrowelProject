using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GMSAPI.Migrations
{
    public partial class GrowelInitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AadharDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AadharName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AadharDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BankDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BankAccountNumber = table.Column<string>(nullable: true),
                    BankName = table.Column<string>(nullable: true),
                    IFSCCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeptName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DeptID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeptName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DeptID);
                });

            migrationBuilder.CreateTable(
                name: "PanCardDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PanSurName = table.Column<string>(nullable: true),
                    PanMiddleName = table.Column<string>(nullable: true),
                    PanFirstName = table.Column<string>(nullable: true),
                    PanNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PanCardDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PassPortDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PassPortNumber = table.Column<string>(nullable: true),
                    PassportName = table.Column<string>(nullable: true),
                    PassportSurname = table.Column<string>(nullable: true),
                    PassportIssueDate = table.Column<string>(nullable: true),
                    PassportExpiryDate = table.Column<string>(nullable: true),
                    PassportIssuedPlace = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassPortDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SegmentDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SegmentName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SegmentDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StateDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StateName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Designations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DesignationName = table.Column<string>(nullable: true),
                    DeptId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Designations_Departments_DeptId",
                        column: x => x.DeptId,
                        principalTable: "Departments",
                        principalColumn: "DeptID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeRoots",
                columns: table => new
                {
                    Eid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Fname = table.Column<string>(nullable: true),
                    Lname = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    DoJ = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    IsAdmin = table.Column<bool>(nullable: false),
                    deptID = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeRoots", x => x.Eid);
                    table.ForeignKey(
                        name: "FK_EmployeeRoots_Departments_deptID",
                        column: x => x.deptID,
                        principalTable: "Departments",
                        principalColumn: "DeptID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DistrictDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DistrictName = table.Column<string>(nullable: true),
                    StateID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistrictDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DistrictDetails_StateDetails_StateID",
                        column: x => x.StateID,
                        principalTable: "StateDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HeadQuatersDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HeadQuatersName = table.Column<string>(nullable: true),
                    SegmentID = table.Column<int>(nullable: false),
                    DistrictID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeadQuatersDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HeadQuatersDetails_DistrictDetails_DistrictID",
                        column: x => x.DistrictID,
                        principalTable: "DistrictDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeadQuatersDetails_SegmentDetails_SegmentID",
                        column: x => x.SegmentID,
                        principalTable: "SegmentDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MasterEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmpCode = table.Column<string>(nullable: true),
                    EmpName = table.Column<string>(nullable: true),
                    ReportingTo = table.Column<int>(nullable: false),
                    Pincode = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    DOJ = table.Column<string>(nullable: true),
                    DOB = table.Column<string>(nullable: true),
                    BloogGroup = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    ShirtSize = table.Column<int>(nullable: false),
                    DepartmentInfoId = table.Column<int>(nullable: true),
                    DeptID = table.Column<int>(nullable: false),
                    DesignationID = table.Column<int>(nullable: false),
                    SegmentID = table.Column<int>(nullable: false),
                    HQID = table.Column<int>(nullable: false),
                    DistrictId = table.Column<int>(nullable: true),
                    DistID = table.Column<int>(nullable: false),
                    StateID = table.Column<int>(nullable: false),
                    AadharID = table.Column<int>(nullable: false),
                    BankID = table.Column<int>(nullable: false),
                    PanID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterEmployees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MasterEmployees_AadharDetails_AadharID",
                        column: x => x.AadharID,
                        principalTable: "AadharDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MasterEmployees_BankDetails_BankID",
                        column: x => x.BankID,
                        principalTable: "BankDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MasterEmployees_DepartmentInfos_DepartmentInfoId",
                        column: x => x.DepartmentInfoId,
                        principalTable: "DepartmentInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MasterEmployees_Designations_DesignationID",
                        column: x => x.DesignationID,
                        principalTable: "Designations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MasterEmployees_DistrictDetails_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "DistrictDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MasterEmployees_HeadQuatersDetails_HQID",
                        column: x => x.HQID,
                        principalTable: "HeadQuatersDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MasterEmployees_PanCardDetails_PanID",
                        column: x => x.PanID,
                        principalTable: "PanCardDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MasterEmployees_SegmentDetails_SegmentID",
                        column: x => x.SegmentID,
                        principalTable: "SegmentDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MasterEmployees_StateDetails_StateID",
                        column: x => x.StateID,
                        principalTable: "StateDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContactInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContactNo = table.Column<string>(nullable: true),
                    MasterEmployeeId = table.Column<int>(nullable: true),
                    EmpID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactInfos_MasterEmployees_MasterEmployeeId",
                        column: x => x.MasterEmployeeId,
                        principalTable: "MasterEmployees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactInfos_MasterEmployeeId",
                table: "ContactInfos",
                column: "MasterEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Designations_DeptId",
                table: "Designations",
                column: "DeptId");

            migrationBuilder.CreateIndex(
                name: "IX_DistrictDetails_StateID",
                table: "DistrictDetails",
                column: "StateID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRoots_deptID",
                table: "EmployeeRoots",
                column: "deptID");

            migrationBuilder.CreateIndex(
                name: "IX_HeadQuatersDetails_DistrictID",
                table: "HeadQuatersDetails",
                column: "DistrictID");

            migrationBuilder.CreateIndex(
                name: "IX_HeadQuatersDetails_SegmentID",
                table: "HeadQuatersDetails",
                column: "SegmentID");

            migrationBuilder.CreateIndex(
                name: "IX_MasterEmployees_AadharID",
                table: "MasterEmployees",
                column: "AadharID");

            migrationBuilder.CreateIndex(
                name: "IX_MasterEmployees_BankID",
                table: "MasterEmployees",
                column: "BankID");

            migrationBuilder.CreateIndex(
                name: "IX_MasterEmployees_DepartmentInfoId",
                table: "MasterEmployees",
                column: "DepartmentInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_MasterEmployees_DesignationID",
                table: "MasterEmployees",
                column: "DesignationID");

            migrationBuilder.CreateIndex(
                name: "IX_MasterEmployees_DistrictId",
                table: "MasterEmployees",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_MasterEmployees_HQID",
                table: "MasterEmployees",
                column: "HQID");

            migrationBuilder.CreateIndex(
                name: "IX_MasterEmployees_PanID",
                table: "MasterEmployees",
                column: "PanID");

            migrationBuilder.CreateIndex(
                name: "IX_MasterEmployees_SegmentID",
                table: "MasterEmployees",
                column: "SegmentID");

            migrationBuilder.CreateIndex(
                name: "IX_MasterEmployees_StateID",
                table: "MasterEmployees",
                column: "StateID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactInfos");

            migrationBuilder.DropTable(
                name: "EmployeeRoots");

            migrationBuilder.DropTable(
                name: "PassPortDetails");

            migrationBuilder.DropTable(
                name: "MasterEmployees");

            migrationBuilder.DropTable(
                name: "AadharDetails");

            migrationBuilder.DropTable(
                name: "BankDetails");

            migrationBuilder.DropTable(
                name: "DepartmentInfos");

            migrationBuilder.DropTable(
                name: "Designations");

            migrationBuilder.DropTable(
                name: "HeadQuatersDetails");

            migrationBuilder.DropTable(
                name: "PanCardDetails");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "DistrictDetails");

            migrationBuilder.DropTable(
                name: "SegmentDetails");

            migrationBuilder.DropTable(
                name: "StateDetails");
        }
    }
}
