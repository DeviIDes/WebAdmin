using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAdmin.Migrations
{
    public partial class m02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdCorporativo",
                table: "TblClientes");

            migrationBuilder.RenameColumn(
                name: "Rfc",
                table: "TblClientes",
                newName: "ApellidoPaterno");

            migrationBuilder.RenameColumn(
                name: "GiroComercial",
                table: "TblClientes",
                newName: "ApellidoMaterno");

            migrationBuilder.AddColumn<int>(
                name: "CatTipoClienteIdTipoCliente",
                table: "TblClientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CorreoAcceso",
                table: "TblClientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "IdPerfil",
                table: "TblClientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdRol",
                table: "TblClientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdTipoCliente",
                table: "TblClientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CatTipoClientes",
                columns: table => new
                {
                    IdTipoCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoClienteDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEstatusRegistro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatTipoClientes", x => x.IdTipoCliente);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblClientes_CatTipoClienteIdTipoCliente",
                table: "TblClientes",
                column: "CatTipoClienteIdTipoCliente");

            migrationBuilder.AddForeignKey(
                name: "FK_TblClientes_CatTipoClientes_CatTipoClienteIdTipoCliente",
                table: "TblClientes",
                column: "CatTipoClienteIdTipoCliente",
                principalTable: "CatTipoClientes",
                principalColumn: "IdTipoCliente",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblClientes_CatTipoClientes_CatTipoClienteIdTipoCliente",
                table: "TblClientes");

            migrationBuilder.DropTable(
                name: "CatTipoClientes");

            migrationBuilder.DropIndex(
                name: "IX_TblClientes_CatTipoClienteIdTipoCliente",
                table: "TblClientes");

            migrationBuilder.DropColumn(
                name: "CatTipoClienteIdTipoCliente",
                table: "TblClientes");

            migrationBuilder.DropColumn(
                name: "CorreoAcceso",
                table: "TblClientes");

            migrationBuilder.DropColumn(
                name: "IdPerfil",
                table: "TblClientes");

            migrationBuilder.DropColumn(
                name: "IdRol",
                table: "TblClientes");

            migrationBuilder.DropColumn(
                name: "IdTipoCliente",
                table: "TblClientes");

            migrationBuilder.RenameColumn(
                name: "ApellidoPaterno",
                table: "TblClientes",
                newName: "Rfc");

            migrationBuilder.RenameColumn(
                name: "ApellidoMaterno",
                table: "TblClientes",
                newName: "GiroComercial");

            migrationBuilder.AddColumn<Guid>(
                name: "IdCorporativo",
                table: "TblClientes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
