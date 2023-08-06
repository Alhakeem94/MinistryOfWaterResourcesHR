using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace homework.Data.Migrations
{
    public partial class addgeolocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GeoLocationClassifies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GeoLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeoLocationFee = table.Column<float>(type: "real", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeoLocationClassifies", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GeoLocationClassifies");
        }
    }
}
