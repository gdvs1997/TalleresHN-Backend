using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendTalleresHN.FuenteDatos.Migrations
{
    public partial class CreateTblEmpresa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_AspNetUsers_UserId",
                table: "Cliente");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Cliente",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255) CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreEmpresa = table.Column<string>(nullable: false),
                    NombreDueño = table.Column<string>(nullable: false),
                    Direccion = table.Column<string>(nullable: false),
                    Longitud = table.Column<float>(nullable: false),
                    Latitud = table.Column<float>(nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    FechaInscripcion = table.Column<DateTime>(nullable: false),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empresa_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_UserId",
                table: "Empresa",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_AspNetUsers_UserId",
                table: "Cliente",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_AspNetUsers_UserId",
                table: "Cliente");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Cliente",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_AspNetUsers_UserId",
                table: "Cliente",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
