using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendTalleresHN.FuenteDatos.Migrations
{
    public partial class UpdateNameEmpresaATaller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleado_Empresa_TallerId1",
                table: "Empleado");

            migrationBuilder.DropForeignKey(
                name: "FK_Empresa_AspNetUsers_UserId",
                table: "Empresa");

            migrationBuilder.DropForeignKey(
                name: "FK_TallerRelacionTipoTaller_Empresa_TallerId",
                table: "TallerRelacionTipoTaller");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Empresa",
                table: "Empresa");

            migrationBuilder.RenameTable(
                name: "Empresa",
                newName: "Taller");

            migrationBuilder.RenameIndex(
                name: "IX_Empresa_UserId",
                table: "Taller",
                newName: "IX_Taller_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Taller",
                table: "Taller",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleado_Taller_TallerId1",
                table: "Empleado",
                column: "TallerId1",
                principalTable: "Taller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Taller_AspNetUsers_UserId",
                table: "Taller",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TallerRelacionTipoTaller_Taller_TallerId",
                table: "TallerRelacionTipoTaller",
                column: "TallerId",
                principalTable: "Taller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleado_Taller_TallerId1",
                table: "Empleado");

            migrationBuilder.DropForeignKey(
                name: "FK_Taller_AspNetUsers_UserId",
                table: "Taller");

            migrationBuilder.DropForeignKey(
                name: "FK_TallerRelacionTipoTaller_Taller_TallerId",
                table: "TallerRelacionTipoTaller");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Taller",
                table: "Taller");

            migrationBuilder.RenameTable(
                name: "Taller",
                newName: "Empresa");

            migrationBuilder.RenameIndex(
                name: "IX_Taller_UserId",
                table: "Empresa",
                newName: "IX_Empresa_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empresa",
                table: "Empresa",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleado_Empresa_TallerId1",
                table: "Empleado",
                column: "TallerId1",
                principalTable: "Empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Empresa_AspNetUsers_UserId",
                table: "Empresa",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TallerRelacionTipoTaller_Empresa_TallerId",
                table: "TallerRelacionTipoTaller",
                column: "TallerId",
                principalTable: "Empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
