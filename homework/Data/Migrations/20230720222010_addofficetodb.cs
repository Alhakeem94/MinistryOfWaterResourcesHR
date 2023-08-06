using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace homework.Data.Migrations
{
    public partial class addofficetodb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OfficeTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OfficeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Officetable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Deparmenttable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OfficeTableId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deparmenttable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deparmenttable_Officetable_OfficeTableId",
                        column: x => x.OfficeTableId,
                        principalTable: "OfficeTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Deparmenttable_OfficeTableId",
                table: "Deparmenttable",
                column: "OfficeTableId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deparmenttable");

            migrationBuilder.DropTable(
                name: "OfficeTable");
        }
    }
}
