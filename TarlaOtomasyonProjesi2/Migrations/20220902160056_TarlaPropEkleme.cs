using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TarlaOtomasyonProjesi2.Migrations
{
    public partial class TarlaPropEkleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IlacAdetBirimFiyat",
                table: "Tarlalar",
                newName: "IlacEkim2masraf");

            migrationBuilder.RenameColumn(
                name: "IlacAdet",
                table: "Tarlalar",
                newName: "IlacEkim1Masraf");

            migrationBuilder.AddColumn<double>(
                name: "DigerIlacMasraf",
                table: "Tarlalar",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "HolderlemeMasraf",
                table: "Tarlalar",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DigerIlacMasraf",
                table: "Tarlalar");

            migrationBuilder.DropColumn(
                name: "HolderlemeMasraf",
                table: "Tarlalar");

            migrationBuilder.RenameColumn(
                name: "IlacEkim2masraf",
                table: "Tarlalar",
                newName: "IlacAdetBirimFiyat");

            migrationBuilder.RenameColumn(
                name: "IlacEkim1Masraf",
                table: "Tarlalar",
                newName: "IlacAdet");
        }
    }
}
