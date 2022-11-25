using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TarlaOtomasyonProjesi2.Migrations
{
    public partial class FirstMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IsciToplamUcret",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IsciToplamUcret = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsciToplamUcret", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tarlalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TarlaParselNo = table.Column<string>(type: "TEXT", nullable: false),
                    Donum = table.Column<double>(type: "REAL", nullable: false),
                    Maliyet = table.Column<double>(type: "REAL", nullable: false),
                    EkipmanMaliyet = table.Column<double>(type: "REAL", nullable: false),
                    TohumKg = table.Column<double>(type: "REAL", nullable: false),
                    GubreKg = table.Column<double>(type: "REAL", nullable: false),
                    IlacAdet = table.Column<double>(type: "REAL", nullable: false),
                    MatozLitre = table.Column<double>(type: "REAL", nullable: false),
                    TohumKgBirimFiyat = table.Column<double>(type: "REAL", nullable: false),
                    GubreKgBirimFiyat = table.Column<double>(type: "REAL", nullable: false),
                    IlacAdetBirimFiyat = table.Column<double>(type: "REAL", nullable: false),
                    MatozLitreBirimFiyat = table.Column<double>(type: "REAL", nullable: false),
                    BicimMasrafTotal = table.Column<double>(type: "REAL", nullable: false),
                    DigerNasraflar = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarlalar", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IsciToplamUcret");

            migrationBuilder.DropTable(
                name: "Tarlalar");
        }
    }
}
