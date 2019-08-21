﻿// <auto-generated />
using System;
using HR_Management_System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HR_Management_System.Migrations
{
    [DbContext(typeof(HRMS_DB_Context))]
    [Migration("20190820192447_AttendanceAdded")]
    partial class AttendanceAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HR_Management_System.Models.Attendance", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<int>("Day");

                    b.Property<int>("Month");

                    b.Property<int>("Status");

                    b.Property<long?>("UserModelId");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.HasIndex("UserModelId");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("HR_Management_System.Models.DegreeDetails", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Grade");

                    b.Property<string>("Institute");

                    b.Property<string>("PassingYear");

                    b.Property<string>("Qualification");

                    b.Property<long?>("ResumeId");

                    b.Property<string>("Subject");

                    b.HasKey("Id");

                    b.HasIndex("ResumeId");

                    b.ToTable("DegreeDetails");
                });

            modelBuilder.Entity("HR_Management_System.Models.DepartmentModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("HR_Management_System.Models.DesignationModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("DepartmentModelId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("DepartmentModelId");

                    b.ToTable("Designations");
                });

            modelBuilder.Entity("HR_Management_System.Models.HolidayModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.ToTable("Holidays");
                });

            modelBuilder.Entity("HR_Management_System.Models.LeaveApplication", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AppliedDate");

                    b.Property<int>("Days");

                    b.Property<DateTime>("EndDate");

                    b.Property<long>("LeaveCategoryId");

                    b.Property<string>("Reason");

                    b.Property<DateTime>("StartDate");

                    b.Property<int>("Status");

                    b.Property<long?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("LeaveCategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("LeaveApplications");
                });

            modelBuilder.Entity("HR_Management_System.Models.LeaveCategory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Days");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("LeaveCategories");
                });

            modelBuilder.Entity("HR_Management_System.Models.Notice", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<bool>("Published");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Notices");
                });

            modelBuilder.Entity("HR_Management_System.Models.ProfessionalExperience", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyAddress");

                    b.Property<string>("CompanyName");

                    b.Property<DateTime?>("DurationFrom");

                    b.Property<DateTime?>("DurationTo");

                    b.Property<long?>("ResumeId");

                    b.Property<string>("Role");

                    b.HasKey("Id");

                    b.HasIndex("ResumeId");

                    b.ToTable("ProfessionalExperience");
                });

            modelBuilder.Entity("HR_Management_System.Models.RecruitementNoticeModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Department")
                        .IsRequired();

                    b.Property<string>("Description");

                    b.Property<string>("Designation")
                        .IsRequired();

                    b.Property<bool>("IsPublished");

                    b.Property<DateTime>("LastDate");

                    b.Property<int>("NumberOfVacancy");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("RecruitementNotices");
                });

            modelBuilder.Entity("HR_Management_System.Models.Resume", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateOfBirth");

                    b.Property<string>("Email");

                    b.Property<string>("FatherName");

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender");

                    b.Property<string>("LastName");

                    b.Property<string>("MarritualStatus");

                    b.Property<string>("MobileNumber");

                    b.Property<string>("MotherName");

                    b.Property<string>("NationalID");

                    b.Property<string>("Nationality");

                    b.Property<string>("PermanentAddress");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("PresentAddress");

                    b.Property<byte[]>("ProfileImage");

                    b.Property<string>("Religion");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Resumes");
                });

            modelBuilder.Entity("HR_Management_System.Models.Salary", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("BasicSalary");

                    b.Property<double>("GrossSalary");

                    b.Property<double>("HouseRent");

                    b.Property<double>("MedicalBill");

                    b.Property<double>("MobileBill");

                    b.Property<double>("NetSalary");

                    b.Property<double>("Other");

                    b.Property<double>("OtherDeduction");

                    b.Property<double>("ProvidentFundDeduction");

                    b.Property<double>("TaxDeduction");

                    b.Property<double>("TotalDeduction");

                    b.HasKey("Id");

                    b.ToTable("Salaries");
                });

            modelBuilder.Entity("HR_Management_System.Models.UserModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateOfApplication");

                    b.Property<string>("Department");

                    b.Property<string>("Designation");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<DateTime?>("InterviewDate");

                    b.Property<DateTime?>("JoiningDate");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<byte[]>("ProfileImage");

                    b.Property<long?>("RecruitementNoticeModelId");

                    b.Property<bool>("RememberMe");

                    b.Property<long?>("ResumeId");

                    b.Property<long?>("SalaryId");

                    b.Property<bool>("SelectedForInterview");

                    b.Property<bool>("Status");

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.Property<int>("UserType");

                    b.HasKey("Id");

                    b.HasIndex("RecruitementNoticeModelId");

                    b.HasIndex("ResumeId");

                    b.HasIndex("SalaryId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("HR_Management_System.Models.WeekDayModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsWorkingDay");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("WeekDays");
                });

            modelBuilder.Entity("HR_Management_System.Models.Attendance", b =>
                {
                    b.HasOne("HR_Management_System.Models.UserModel")
                        .WithMany("Attendances")
                        .HasForeignKey("UserModelId");
                });

            modelBuilder.Entity("HR_Management_System.Models.DegreeDetails", b =>
                {
                    b.HasOne("HR_Management_System.Models.Resume")
                        .WithMany("EducationalDetails")
                        .HasForeignKey("ResumeId");
                });

            modelBuilder.Entity("HR_Management_System.Models.DesignationModel", b =>
                {
                    b.HasOne("HR_Management_System.Models.DepartmentModel")
                        .WithMany("Designation")
                        .HasForeignKey("DepartmentModelId");
                });

            modelBuilder.Entity("HR_Management_System.Models.LeaveApplication", b =>
                {
                    b.HasOne("HR_Management_System.Models.LeaveCategory", "LeaveCategory")
                        .WithMany()
                        .HasForeignKey("LeaveCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HR_Management_System.Models.UserModel", "User")
                        .WithMany("LeaveApplications")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("HR_Management_System.Models.ProfessionalExperience", b =>
                {
                    b.HasOne("HR_Management_System.Models.Resume")
                        .WithMany("Experiences")
                        .HasForeignKey("ResumeId");
                });

            modelBuilder.Entity("HR_Management_System.Models.UserModel", b =>
                {
                    b.HasOne("HR_Management_System.Models.RecruitementNoticeModel")
                        .WithMany("Applicants")
                        .HasForeignKey("RecruitementNoticeModelId");

                    b.HasOne("HR_Management_System.Models.Resume", "Resume")
                        .WithMany()
                        .HasForeignKey("ResumeId");

                    b.HasOne("HR_Management_System.Models.Salary", "Salary")
                        .WithMany()
                        .HasForeignKey("SalaryId");
                });
#pragma warning restore 612, 618
        }
    }
}
