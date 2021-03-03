using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendTalleresHN.FuenteDatos.Migrations
{
    public partial class UpdateFKEmpleado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleado_Taller_TallerId1",
                table: "Empleado");

            migrationBuilder.DropIndex(
                name: "IX_Empleado_TallerId1",
                table: "Empleado");

            migrationBuilder.DropColumn(
                name: "TallerId1",
                table: "Empleado");

            migrationBuilder.AlterColumn<int>(
                name: "TallerId",
                table: "Empleado",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_TallerId",
                table: "Empleado",
                column: "TallerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleado_Taller_TallerId",
                table: "Empleado",
                column: "TallerId",
                principalTable: "Taller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleado_Taller_TallerId",
                table: "Empleado");

            migrationBuilder.DropIndex(
                name: "IX_Empleado_TallerId",
                table: "Empleado");

            migrationBuilder.AlterColumn<string>(
                name: "TallerId",
                table: "Empleado",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "TallerId1",
                table: "Empleado",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_TallerId1",
                table: "Empleado",
                column: "TallerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleado_Taller_TallerId1",
                table: "Empleado",
                column: "TallerId1",
                principalTable: "Taller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
