using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Taller64.Migrations
{
    public partial class CreateNewTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistorialAcceso_Usuarios_UsuarioId",
                table: "HistorialAcceso");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Genero_GeneroId",
                table: "Usuarios");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "NombreUsuario",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "clave",
                table: "Usuarios");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "Usuario");

            migrationBuilder.RenameColumn(
                name: "fecha_registro",
                table: "Usuario",
                newName: "FechaRegistro");

            migrationBuilder.RenameColumn(
                name: "estado",
                table: "Usuario",
                newName: "EstadoUsuario");

            migrationBuilder.RenameColumn(
                name: "GeneroId",
                table: "Usuario",
                newName: "DepartamentoId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Usuario",
                newName: "UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_GeneroId",
                table: "Usuario",
                newName: "IX_Usuario_DepartamentoId");

            migrationBuilder.AddColumn<string>(
                name: "Apellidos",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nombres",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "UsuarioId");

            migrationBuilder.CreateTable(
                name: "CredencialesAcceso",
                columns: table => new
                {
                    NombreUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_CredencialesAcceso_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Departamento",
                columns: table => new
                {
                    DepartamentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreDepartamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoDepartamento = table.Column<bool>(type: "bit", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamento", x => x.DepartamentoId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CredencialesAcceso_UsuarioId",
                table: "CredencialesAcceso",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_HistorialAcceso_Usuario_UsuarioId",
                table: "HistorialAcceso",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Departamento_DepartamentoId",
                table: "Usuario",
                column: "DepartamentoId",
                principalTable: "Departamento",
                principalColumn: "DepartamentoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistorialAcceso_Usuario_UsuarioId",
                table: "HistorialAcceso");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Departamento_DepartamentoId",
                table: "Usuario");

            migrationBuilder.DropTable(
                name: "CredencialesAcceso");

            migrationBuilder.DropTable(
                name: "Departamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Apellidos",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Nombres",
                table: "Usuario");

            migrationBuilder.RenameTable(
                name: "Usuario",
                newName: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "FechaRegistro",
                table: "Usuarios",
                newName: "fecha_registro");

            migrationBuilder.RenameColumn(
                name: "EstadoUsuario",
                table: "Usuarios",
                newName: "estado");

            migrationBuilder.RenameColumn(
                name: "DepartamentoId",
                table: "Usuarios",
                newName: "GeneroId");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Usuarios",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Usuario_DepartamentoId",
                table: "Usuarios",
                newName: "IX_Usuarios_GeneroId");

            migrationBuilder.AddColumn<string>(
                name: "NombreUsuario",
                table: "Usuarios",
                type: "varchar(10)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "clave",
                table: "Usuarios",
                type: "varchar(10)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    estado = table.Column<bool>(type: "bit", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_HistorialAcceso_Usuarios_UsuarioId",
                table: "HistorialAcceso",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Genero_GeneroId",
                table: "Usuarios",
                column: "GeneroId",
                principalTable: "Genero",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
