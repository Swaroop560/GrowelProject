﻿// <auto-generated />
using System;
using GrowelAPI.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GMSAPI.Migrations
{
    [DbContext(typeof(EmployeeDataContext))]
    partial class EmployeeDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GMSAPI.Model.AadharDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AadharName");

                    b.HasKey("Id");

                    b.ToTable("AadharDetails");
                });

            modelBuilder.Entity("GMSAPI.Model.BankDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BankAccountNumber");

                    b.Property<string>("BankName");

                    b.Property<string>("IFSCCode");

                    b.HasKey("Id");

                    b.ToTable("BankDetails");
                });

            modelBuilder.Entity("GMSAPI.Model.ContactInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactNo");

                    b.Property<int>("EmpID");

                    b.Property<int?>("MasterEmployeeId");

                    b.HasKey("Id");

                    b.HasIndex("MasterEmployeeId");

                    b.ToTable("ContactInfos");
                });

            modelBuilder.Entity("GMSAPI.Model.DepartmentInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DeptName");

                    b.HasKey("Id");

                    b.ToTable("DepartmentInfos");
                });

            modelBuilder.Entity("GMSAPI.Model.Designation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DeptId");

                    b.Property<string>("DesignationName");

                    b.HasKey("Id");

                    b.HasIndex("DeptId");

                    b.ToTable("Designations");
                });

            modelBuilder.Entity("GMSAPI.Model.DistrictDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DistrictName");

                    b.Property<int>("StateID");

                    b.HasKey("Id");

                    b.HasIndex("StateID");

                    b.ToTable("DistrictDetails");
                });

            modelBuilder.Entity("GMSAPI.Model.HeadQuatersDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DistrictID");

                    b.Property<string>("HeadQuatersName");

                    b.Property<int>("SegmentID");

                    b.HasKey("Id");

                    b.HasIndex("DistrictID");

                    b.HasIndex("SegmentID");

                    b.ToTable("HeadQuatersDetails");
                });

            modelBuilder.Entity("GMSAPI.Model.MasterEmployee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AadharID");

                    b.Property<int>("BankID");

                    b.Property<string>("BloogGroup");

                    b.Property<string>("DOB");

                    b.Property<string>("DOJ");

                    b.Property<int>("DepartmentID");

                    b.Property<int>("DesignationID");

                    b.Property<int>("DistID");

                    b.Property<int?>("DistrictId");

                    b.Property<string>("Email");

                    b.Property<string>("EmpCode");

                    b.Property<string>("EmpName");

                    b.Property<int>("HQID");

                    b.Property<string>("ImagePath");

                    b.Property<int>("PanID");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<int>("Pincode");

                    b.Property<int>("ReportingTo");

                    b.Property<int>("SegmentID");

                    b.Property<int>("ShirtSize");

                    b.Property<int>("StateID");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.HasIndex("AadharID");

                    b.HasIndex("BankID");

                    b.HasIndex("DepartmentID");

                    b.HasIndex("DesignationID");

                    b.HasIndex("DistrictId");

                    b.HasIndex("HQID");

                    b.HasIndex("PanID");

                    b.HasIndex("SegmentID");

                    b.HasIndex("StateID");

                    b.ToTable("MasterEmployees");
                });

            modelBuilder.Entity("GMSAPI.Model.PanCardDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PanFirstName");

                    b.Property<string>("PanMiddleName");

                    b.Property<string>("PanNo");

                    b.Property<string>("PanSurName");

                    b.HasKey("Id");

                    b.ToTable("PanCardDetails");
                });

            modelBuilder.Entity("GMSAPI.Model.PassPortDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PassPortNumber");

                    b.Property<string>("PassportExpiryDate");

                    b.Property<string>("PassportIssueDate");

                    b.Property<string>("PassportIssuedPlace");

                    b.Property<string>("PassportName");

                    b.Property<string>("PassportSurname");

                    b.HasKey("Id");

                    b.ToTable("PassPortDetails");
                });

            modelBuilder.Entity("GMSAPI.Model.SegmentDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SegmentName");

                    b.HasKey("Id");

                    b.ToTable("SegmentDetails");
                });

            modelBuilder.Entity("GMSAPI.Model.StateDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StateName");

                    b.HasKey("Id");

                    b.ToTable("StateDetails");
                });

            modelBuilder.Entity("GrowelAPI.Model.Login", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("UserRole");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Logins");
                });

            modelBuilder.Entity("GMSAPI.Model.ContactInfo", b =>
                {
                    b.HasOne("GMSAPI.Model.MasterEmployee", "MasterEmployee")
                        .WithMany("Contacts")
                        .HasForeignKey("MasterEmployeeId");
                });

            modelBuilder.Entity("GMSAPI.Model.Designation", b =>
                {
                    b.HasOne("GMSAPI.Model.DepartmentInfo", "Dept")
                        .WithMany()
                        .HasForeignKey("DeptId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GMSAPI.Model.DistrictDetail", b =>
                {
                    b.HasOne("GMSAPI.Model.StateDetail", "State")
                        .WithMany()
                        .HasForeignKey("StateID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GMSAPI.Model.HeadQuatersDetail", b =>
                {
                    b.HasOne("GMSAPI.Model.DistrictDetail", "District")
                        .WithMany()
                        .HasForeignKey("DistrictID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GMSAPI.Model.SegmentDetail", "Segment")
                        .WithMany()
                        .HasForeignKey("SegmentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GMSAPI.Model.MasterEmployee", b =>
                {
                    b.HasOne("GMSAPI.Model.AadharDetail", "Aadhar")
                        .WithMany()
                        .HasForeignKey("AadharID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GMSAPI.Model.BankDetail", "Bank")
                        .WithMany()
                        .HasForeignKey("BankID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GMSAPI.Model.DepartmentInfo", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GMSAPI.Model.Designation", "Designation")
                        .WithMany()
                        .HasForeignKey("DesignationID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GMSAPI.Model.DistrictDetail", "District")
                        .WithMany()
                        .HasForeignKey("DistrictId");

                    b.HasOne("GMSAPI.Model.HeadQuatersDetail", "HQ")
                        .WithMany()
                        .HasForeignKey("HQID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GMSAPI.Model.PanCardDetail", "Pan")
                        .WithMany()
                        .HasForeignKey("PanID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GMSAPI.Model.SegmentDetail", "Segment")
                        .WithMany()
                        .HasForeignKey("SegmentID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GMSAPI.Model.StateDetail", "State")
                        .WithMany()
                        .HasForeignKey("StateID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
