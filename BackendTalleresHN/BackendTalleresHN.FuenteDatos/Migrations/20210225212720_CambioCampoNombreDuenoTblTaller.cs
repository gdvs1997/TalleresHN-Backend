using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendTalleresHN.FuenteDatos.Migrations
{
    public partial class CambioCampoNombreDuenoTblTaller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NombreDueño",
                table: "Taller");

            migrationBuilder.AddColumn<string>(
                name: "NombrePropietario",
                table: "Taller",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NombrePropietario",
                table: "Taller");

            migrationBuilder.AddColumn<string>(
                name: "NombreDueño",
                table: "Taller",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                defaultValue: "");
        }
    }
}
