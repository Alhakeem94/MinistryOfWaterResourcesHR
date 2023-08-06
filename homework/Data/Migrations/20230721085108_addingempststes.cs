using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace homework.Data.Migrations
{
    public partial class addingempststes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CertificateClassifies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Certification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CertificationPercentage = table.Column<int>(type: "int", nullable: false),
                    HighCertificationPercentage = table.Column<int>(type: "int", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificateClassifies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentSubjectClassifies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentSubject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentSubjectClassifies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentTypeClassifies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTypeClassifies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmpStatesClassifies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpStates = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpStatesClassifies", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CertificateClassifies");

            migrationBuilder.DropTable(
                name: "DocumentSubjectClassifies");

            migrationBuilder.DropTable(
                name: "DocumentTypeClassifies");

            migrationBuilder.DropTable(
                name: "EmpStatesClassifies");
        }
    }
}
