using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Taller64.Migrations
{
    public partial class v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CredencialesAcceso_Usuario_UsuarioId",
                table: "CredencialesAcceso");

            migrationBuilder.DropForeignKey(
                name: "FK_HistorialAcceso_Usuario_UsuarioId",
                table: "HistorialAcceso");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_HistorialAcceso_UsuarioId",
                table: "HistorialAcceso");

            migrationBuilder.DropIndex(
                name: "IX_CredencialesAcceso_UsuarioId",
                table: "CredencialesAcceso");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "HistorialAcceso");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "CredencialesAcceso");

            migrationBuilder.AddColumn<string>(
                name: "Cedula",
                table: "Usuario",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cedula",
                table: "HistorialAcceso",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cedula",
                table: "CredencialesAcceso",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "Cedula");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialAcceso_Cedula",
                table: "HistorialAcceso",
                column: "Cedula");

            migrationBuilder.CreateIndex(
                name: "IX_CredencialesAcceso_Cedula",
                table: "CredencialesAcceso",
                column: "Cedula");

            migrationBuilder.AddForeignKey(
                name: "FK_CredencialesAcceso_Usuario_Cedula",
                table: "CredencialesAcceso",
                column: "Cedula",
                principalTable: "Usuario",
                principalColumn: "Cedula",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HistorialAcceso_Usuario_Cedula",
                table: "HistorialAcceso",
                column: "Cedula",
                principalTable: "Usuario",
                principalColumn: "Cedula",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CredencialesAcceso_Usuario_Cedula",
                table: "CredencialesAcceso");

            migrationBuilder.DropForeignKey(
                name: "FK_HistorialAcceso_Usuario_Cedula",
                table: "HistorialAcceso");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_HistorialAcceso_Cedula",
                table: "HistorialAcceso");

            migrationBuilder.DropIndex(
                name: "IX_CredencialesAcceso_Cedula",
                table: "CredencialesAcceso");

            migrationBuilder.DropColumn(
                name: "Cedula",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Cedula",
                table: "HistorialAcceso");

            migrationBuilder.DropColumn(
                name: "Cedula",
                table: "CredencialesAcceso");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Usuario",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "HistorialAcceso",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "CredencialesAcceso",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialAcceso_UsuarioId",
                table: "HistorialAcceso",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_CredencialesAcceso_UsuarioId",
                table: "CredencialesAcceso",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_CredencialesAcceso_Usuario_UsuarioId",
                table: "CredencialesAcceso",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HistorialAcceso_Usuario_UsuarioId",
                table: "HistorialAcceso",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
