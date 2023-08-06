using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace homework.Data.Migrations
{
    public partial class addemploycontextdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employtable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpNumber = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThirdName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FourthName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpPicture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpCivilNum = table.Column<int>(type: "int", nullable: false),
                    EmpPosition = table.Column<int>(type: "int", nullable: false),
                    PositionStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PositionOrderNum = table.Column<int>(type: "int", nullable: false),
                    OfficeModel = table.Column<int>(type: "int", nullable: false),
                    Department = table.Column<int>(type: "int", nullable: false),
                    GeoLocation = table.Column<int>(type: "int", nullable: false),
                    CareerType = table.Column<int>(type: "int", nullable: false),
                    JobTitle = table.Column<int>(type: "int", nullable: false),
                    JobDegree = table.Column<int>(type: "int", nullable: false),
                    JobDegreeSection = table.Column<int>(type: "int", nullable: false),
                    JobHiretDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JobOrderNum = table.Column<int>(type: "int", nullable: false),
                    JobStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DirectOrderNum = table.Column<int>(type: "int", nullable: false),
                    DirectDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BounsDeserveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ServiceAddedPerYear = table.Column<int>(type: "int", nullable: false),
                    ServiceAddedPerMonth = table.Column<int>(type: "int", nullable: false),
                    ServiceAddedPerDay = table.Column<int>(type: "int", nullable: false),
                    ServiceDeletedPerYear = table.Column<int>(type: "int", nullable: false),
                    ServiceDeletedPerMonth = table.Column<int>(type: "int", nullable: false),
                    ServiceDeletedPerDay = table.Column<int>(type: "int", nullable: false),
                    ServiceNotes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpState = table.Column<int>(type: "int", nullable: false),
                    AdministrativePosition = table.Column<int>(type: "int", nullable: false),
                    EmploymentStatusOrderNumber = table.Column<int>(type: "int", nullable: false),
                    EmploymentStatusOrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BreakupDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OfficeAssignedTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentCertificate = table.Column<int>(type: "int", nullable: false),
                    EmpSpecialization = table.Column<int>(type: "int", nullable: false),
                    GraduationYear = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmpCollage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpGovernorate = table.Column<int>(type: "int", nullable: false),
                    EmpDistrict = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpAlley = table.Column<int>(type: "int", nullable: false),
                    Emplocality = table.Column<int>(type: "int", nullable: false),
                    HouseNumber = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    HousingState = table.Column<int>(type: "int", nullable: false),
                    HouseType = table.Column<int>(type: "int", nullable: false),
                    EmpGender = table.Column<int>(type: "int", nullable: false),
                    BirthPlace = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmpNationalism = table.Column<int>(type: "int", nullable: false),
                    EmpReligion = table.Column<int>(type: "int", nullable: false),
                    EmpNationality = table.Column<int>(type: "int", nullable: false),
                    MaritalStatus = table.Column<int>(type: "int", nullable: false),
                    WifeHusbandName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WifeHusbandNationality = table.Column<int>(type: "int", nullable: false),
                    NumOfKids = table.Column<int>(type: "int", nullable: false),
                    WifeHusbandCarrer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalityCertificateNumber = table.Column<int>(type: "int", nullable: false),
                    CitizenshipCertificateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CivilStatusIdentificationNumber = table.Column<int>(type: "int", nullable: false),
                    CitizenshipCertificateIssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UnifiedNationalCardNumber = table.Column<int>(type: "int", nullable: false),
                    UnifiedIssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Issuer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RationCardNumber = table.Column<int>(type: "int", nullable: false),
                    FoodNameCenter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpNotes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employtable", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employtable");
        }
    }
}
