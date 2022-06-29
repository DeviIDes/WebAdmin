using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAdmin.Migrations
{
    public partial class m03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdAreaNavigationIdArea",
                table: "TblUsuarios");

            migrationBuilder.DropColumn(
                name: "IdGeneroNavigationIdGenero",
                table: "TblUsuarios");

            migrationBuilder.DropColumn(
                name: "IdPerfilNavigationIdPerfil",
                table: "TblUsuarios");

            migrationBuilder.DropColumn(
                name: "IdRolNavigationIdRol",
                table: "TblUsuarios");

            migrationBuilder.RenameColumn(
                name: "FechaRegistro",
                table: "TblUsuarios",
                newName: "Fecha Registro");

            migrationBuilder.RenameColumn(
                name: "FechaNacimiento",
                table: "TblUsuarios",
                newName: "Fecha de Nacimiento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Fecha de Nacimiento",
                table: "TblUsuarios",
                newName: "FechaNacimiento");

            migrationBuilder.RenameColumn(
                name: "Fecha Registro",
                table: "TblUsuarios",
                newName: "FechaRegistro");

            migrationBuilder.AddColumn<int>(
                name: "IdAreaNavigationIdArea",
                table: "TblUsuarios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdGeneroNavigationIdGenero",
                table: "TblUsuarios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdPerfilNavigationIdPerfil",
                table: "TblUsuarios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdRolNavigationIdRol",
                table: "TblUsuarios",
                type: "int",
                nullable: true);
        }
    }
}
