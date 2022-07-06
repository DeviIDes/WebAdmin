using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAdmin.Migrations
{
    public partial class m03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CorreoAcceso",
                table: "TblClientes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ClaveAcceso",
                table: "TblClientes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<Guid>(
                name: "IdUCorporativoCentro",
                table: "TblClientes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "CatAreas",
                keyColumn: "IdArea",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatAreas",
                keyColumn: "IdArea",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatAreas",
                keyColumn: "IdArea",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatAreas",
                keyColumn: "IdArea",
                keyValue: 4,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatAreas",
                keyColumn: "IdArea",
                keyValue: 5,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatAreas",
                keyColumn: "IdArea",
                keyValue: 6,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatAreas",
                keyColumn: "IdArea",
                keyValue: 7,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatAreas",
                keyColumn: "IdArea",
                keyValue: 8,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatEstatus",
                keyColumn: "IdEstatusRegistro",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatEstatus",
                keyColumn: "IdEstatusRegistro",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatGeneros",
                keyColumn: "IdGenero",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatGeneros",
                keyColumn: "IdGenero",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatPerfiles",
                keyColumn: "IdPerfil",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatPerfiles",
                keyColumn: "IdPerfil",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatPerfiles",
                keyColumn: "IdPerfil",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatPerfiles",
                keyColumn: "IdPerfil",
                keyValue: 4,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatPerfiles",
                keyColumn: "IdPerfil",
                keyValue: 5,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatRoles",
                keyColumn: "IdRol",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatRoles",
                keyColumn: "IdRol",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatRoles",
                keyColumn: "IdRol",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatRoles",
                keyColumn: "IdRol",
                keyValue: 4,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatTipoCentros",
                keyColumn: "IdTipoCentro",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatTipoCentros",
                keyColumn: "IdTipoCentro",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatTipoPago",
                keyColumn: "IdTipoPago",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatTipoPago",
                keyColumn: "IdTipoPago",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatTipoPago",
                keyColumn: "IdTipoPago",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatTipoPago",
                keyColumn: "IdTipoPago",
                keyValue: 4,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatTipoPago",
                keyColumn: "IdTipoPago",
                keyValue: 5,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdUCorporativoCentro",
                table: "TblClientes");

            migrationBuilder.AlterColumn<string>(
                name: "CorreoAcceso",
                table: "TblClientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClaveAcceso",
                table: "TblClientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "CatAreas",
                keyColumn: "IdArea",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatAreas",
                keyColumn: "IdArea",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatAreas",
                keyColumn: "IdArea",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatAreas",
                keyColumn: "IdArea",
                keyValue: 4,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatAreas",
                keyColumn: "IdArea",
                keyValue: 5,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatAreas",
                keyColumn: "IdArea",
                keyValue: 6,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatAreas",
                keyColumn: "IdArea",
                keyValue: 7,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatAreas",
                keyColumn: "IdArea",
                keyValue: 8,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatEstatus",
                keyColumn: "IdEstatusRegistro",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatEstatus",
                keyColumn: "IdEstatusRegistro",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatGeneros",
                keyColumn: "IdGenero",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatGeneros",
                keyColumn: "IdGenero",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatPerfiles",
                keyColumn: "IdPerfil",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatPerfiles",
                keyColumn: "IdPerfil",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatPerfiles",
                keyColumn: "IdPerfil",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatPerfiles",
                keyColumn: "IdPerfil",
                keyValue: 4,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatPerfiles",
                keyColumn: "IdPerfil",
                keyValue: 5,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatRoles",
                keyColumn: "IdRol",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatRoles",
                keyColumn: "IdRol",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatRoles",
                keyColumn: "IdRol",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatRoles",
                keyColumn: "IdRol",
                keyValue: 4,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatTipoCentros",
                keyColumn: "IdTipoCentro",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatTipoCentros",
                keyColumn: "IdTipoCentro",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatTipoPago",
                keyColumn: "IdTipoPago",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatTipoPago",
                keyColumn: "IdTipoPago",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatTipoPago",
                keyColumn: "IdTipoPago",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatTipoPago",
                keyColumn: "IdTipoPago",
                keyValue: 4,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatTipoPago",
                keyColumn: "IdTipoPago",
                keyValue: 5,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
