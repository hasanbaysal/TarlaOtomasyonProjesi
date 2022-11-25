using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TarlaOtomasyonProjesi2.Migrations
{
    public partial class ekipmanmasrafsecond : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "EkipmanMasrafYeniOzellik",
                table: "IsciToplamUcret",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EkipmanMasrafYeniOzellik",
                table: "IsciToplamUcret");
        }
    }
}
