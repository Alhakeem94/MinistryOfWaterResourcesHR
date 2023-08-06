﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using homework.Data;

#nullable disable

namespace homework.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230722190637_addingapptabel")]
    partial class addingapptabel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("homework.Model.MainClass.DepartmentModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OfficeTableId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OfficeTableId");

                    b.ToTable("Deparmenttable");
                });

            modelBuilder.Entity("homework.Model.MainClass.EmployeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AdministrativePosition")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("BirthPlace")
                        .HasColumnType("int");

                    b.Property<DateTime>("BounsDeserveDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BreakupDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CareerType")
                        .HasColumnType("int");

                    b.Property<DateTime>("CitizenshipCertificateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CitizenshipCertificateIssueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CivilStatusIdentificationNumber")
                        .HasColumnType("int");

                    b.Property<int>("CurrentCertificate")
                        .HasColumnType("int");

                    b.Property<int>("Department")
                        .HasColumnType("int");

                    b.Property<DateTime>("DirectDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DirectOrderNum")
                        .HasColumnType("int");

                    b.Property<int>("EmpAlley")
                        .HasColumnType("int");

                    b.Property<int>("EmpCivilNum")
                        .HasColumnType("int");

                    b.Property<string>("EmpCollage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpDistrict")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmpGender")
                        .HasColumnType("int");

                    b.Property<int>("EmpGovernorate")
                        .HasColumnType("int");

                    b.Property<int>("EmpNationalism")
                        .HasColumnType("int");

                    b.Property<int>("EmpNationality")
                        .HasColumnType("int");

                    b.Property<string>("EmpNotes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmpNumber")
                        .HasColumnType("int");

                    b.Property<string>("EmpPicture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmpPosition")
                        .HasColumnType("int");

                    b.Property<int>("EmpReligion")
                        .HasColumnType("int");

                    b.Property<int>("EmpSpecialization")
                        .HasColumnType("int");

                    b.Property<int>("EmpState")
                        .HasColumnType("int");

                    b.Property<int>("Emplocality")
                        .HasColumnType("int");

                    b.Property<DateTime>("EmploymentStatusOrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmploymentStatusOrderNumber")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FoodNameCenter")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FourthName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GeoLocation")
                        .HasColumnType("int");

                    b.Property<DateTime>("GraduationYear")
                        .HasColumnType("datetime2");

                    b.Property<int>("HouseNumber")
                        .HasColumnType("int");

                    b.Property<int>("HouseType")
                        .HasColumnType("int");

                    b.Property<int>("HousingState")
                        .HasColumnType("int");

                    b.Property<string>("Issuer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("JobDegree")
                        .HasColumnType("int");

                    b.Property<int>("JobDegreeSection")
                        .HasColumnType("int");

                    b.Property<DateTime>("JobHiretDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("JobOrderNum")
                        .HasColumnType("int");

                    b.Property<DateTime>("JobStartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("JobTitle")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MaritalStatus")
                        .HasColumnType("int");

                    b.Property<string>("MotherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NationalityCertificateNumber")
                        .HasColumnType("int");

                    b.Property<int>("NumOfKids")
                        .HasColumnType("int");

                    b.Property<string>("OfficeAssignedTo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OfficeModel")
                        .HasColumnType("int");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<int>("PositionOrderNum")
                        .HasColumnType("int");

                    b.Property<DateTime>("PositionStartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RationCardNumber")
                        .HasColumnType("int");

                    b.Property<string>("SecondName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ServiceAddedPerDay")
                        .HasColumnType("int");

                    b.Property<int>("ServiceAddedPerMonth")
                        .HasColumnType("int");

                    b.Property<int>("ServiceAddedPerYear")
                        .HasColumnType("int");

                    b.Property<int>("ServiceDeletedPerDay")
                        .HasColumnType("int");

                    b.Property<int>("ServiceDeletedPerMonth")
                        .HasColumnType("int");

                    b.Property<int>("ServiceDeletedPerYear")
                        .HasColumnType("int");

                    b.Property<string>("ServiceNotes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThirdName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UnifiedIssueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UnifiedNationalCardNumber")
                        .HasColumnType("int");

                    b.Property<int>("UserName")
                        .HasColumnType("int");

                    b.Property<string>("WifeHusbandCarrer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WifeHusbandName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WifeHusbandNationality")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Employtable");
                });

            modelBuilder.Entity("homework.Model.MainClass.OfficeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("OfficeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OfficeTable");
                });

            modelBuilder.Entity("HR.Models.Classifies.AdministrativeStandClassify", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AdministrativeSituation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmpStatsId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserName")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AdministrativeTable");
                });

            modelBuilder.Entity("HR.Models.Classifies.CertificateClassify", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Certification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CertificationPercentage")
                        .HasColumnType("int");

                    b.Property<int>("HighCertificationPercentage")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserName")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Certificatetabel");
                });

            modelBuilder.Entity("HR.Models.Classifies.DocumentSubjectClassify", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DocumentSubject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserName")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DocumentSubjectTable");
                });

            modelBuilder.Entity("HR.Models.Classifies.DocumentTypeClassify", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DocumentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserName")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DocumentTypeTable");
                });

            modelBuilder.Entity("HR.Models.Classifies.EmpStatesClassify", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("EmpStates")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserName")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("EmpStatesTable");
                });

            modelBuilder.Entity("HR.Models.Classifies.GeoLocationClassify", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("GeoLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("GeoLocationFee")
                        .HasColumnType("real");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserName")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GeoLocationTable");
                });

            modelBuilder.Entity("HR.Models.Classifies.GovernorateClassify", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("GovernorateName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserName")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("GovernoraTable");
                });

            modelBuilder.Entity("HR.Models.Classifies.JobDegreeClassify", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("JobDegree")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserName")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("JobDegreeTable");
                });

            modelBuilder.Entity("HR.Models.Classifies.JobLocationClassify", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("JobLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OfficeId")
                        .HasColumnType("int");

                    b.Property<int>("UserName")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("JobLocationTable");
                });

            modelBuilder.Entity("HR.Models.Classifies.JobTitlesClassify", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<int>("UserName")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("JobTitlesTable");
                });

            modelBuilder.Entity("HR.Models.Classifies.LanguageClassify", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserName")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("LanguageTable");
                });

            modelBuilder.Entity("HR.Models.Classifies.MaritalStatusClassify", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MaritalStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserName")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MaritalStatusTable");
                });

            modelBuilder.Entity("HR.Models.Classifies.NationalismClassify", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nationalism")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserName")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("NationalismTable");
                });

            modelBuilder.Entity("HR.Models.Classifies.NationalityClassify", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NationalityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserName")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("NationalityTable");
                });

            modelBuilder.Entity("HR.Models.Classifies.OccupationClassify", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Occupation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserName")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("OccupationTable");
                });

            modelBuilder.Entity("HR.Models.Classifies.PositionClassify", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PositionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PositionProvisions")
                        .HasColumnType("int");

                    b.Property<int>("UserName")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PositionTable");
                });

            modelBuilder.Entity("HR.Models.Classifies.ReligionClassify", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReligionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserName")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("ReligionTable");
                });

            modelBuilder.Entity("HR.Models.Classifies.ServiceClassify", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ServiceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserName")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ServiceTable");
                });

            modelBuilder.Entity("HR.Models.Classifies.ServiceStatusClassify", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ServiceStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserName")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ServiceStatusTable");
                });

            modelBuilder.Entity("HR.Models.Classifies.ServiceTypeClassify", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ServiceType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserName")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ServiceTypeTable");
                });

            modelBuilder.Entity("HR.Models.Classifies.SpecializationClassify", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserName")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SpecializationTable");
                });

            modelBuilder.Entity("HR.Models.Classifies.StageClassify", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Stage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserName")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("StageTable");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("homework.Model.MainClass.DepartmentModel", b =>
                {
                    b.HasOne("homework.Model.MainClass.OfficeModel", "OfficeTable")
                        .WithMany()
                        .HasForeignKey("OfficeTableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OfficeTable");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
