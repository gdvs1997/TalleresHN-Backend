using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendTalleresHN.FuenteDatos.Migrations
{
    public partial class ModificacionC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_AspNetUsers_UserId",
                table: "Cliente");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_UserId",
                table: "Cliente");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Cliente",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255) CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Cliente",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_UserId1",
                table: "Cliente",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_AspNetUsers_UserId1",
                table: "Cliente",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_AspNetUsers_UserId1",
                table: "Cliente");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_UserId1",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Cliente");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Cliente",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_UserId",
                table: "Cliente",
                column: "UserId");

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
