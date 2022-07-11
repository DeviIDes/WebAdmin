using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAdmin.Migrations
{
    public partial class m02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "TblUsuarios",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CorreoAcceso",
                table: "TblClientes",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "TblClientes",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "CatAreas",
                keyColumn: "IdArea",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatAreas",
                keyColumn: "IdArea",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatAreas",
                keyColumn: "IdArea",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatAreas",
                keyColumn: "IdArea",
                keyValue: 4,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatAreas",
                keyColumn: "IdArea",
                keyValue: 5,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatAreas",
                keyColumn: "IdArea",
                keyValue: 6,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatAreas",
                keyColumn: "IdArea",
                keyValue: 7,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatAreas",
                keyColumn: "IdArea",
                keyValue: 8,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatEstatus",
                keyColumn: "IdEstatusRegistro",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatEstatus",
                keyColumn: "IdEstatusRegistro",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatGeneros",
                keyColumn: "IdGenero",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatGeneros",
                keyColumn: "IdGenero",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatPerfiles",
                keyColumn: "IdPerfil",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatPerfiles",
                keyColumn: "IdPerfil",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatPerfiles",
                keyColumn: "IdPerfil",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatPerfiles",
                keyColumn: "IdPerfil",
                keyValue: 4,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatPerfiles",
                keyColumn: "IdPerfil",
                keyValue: 5,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatRoles",
                keyColumn: "IdRol",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatRoles",
                keyColumn: "IdRol",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatRoles",
                keyColumn: "IdRol",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatRoles",
                keyColumn: "IdRol",
                keyValue: 4,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatTipoCentros",
                keyColumn: "IdTipoCentro",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatTipoCentros",
                keyColumn: "IdTipoCentro",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatTipoPago",
                keyColumn: "IdTipoPago",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatTipoPago",
                keyColumn: "IdTipoPago",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatTipoPago",
                keyColumn: "IdTipoPago",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatTipoPago",
                keyColumn: "IdTipoPago",
                keyValue: 4,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatTipoPago",
                keyColumn: "IdTipoPago",
                keyValue: 5,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "TblUsuarios");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "TblClientes");

            migrationBuilder.AlterColumn<string>(
                name: "CorreoAcceso",
                table: "TblClientes",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "CatAreas",
                keyColumn: "IdArea",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatAreas",
                keyColumn: "IdArea",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatAreas",
                keyColumn: "IdArea",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatAreas",
                keyColumn: "IdArea",
                keyValue: 4,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatAreas",
                keyColumn: "IdArea",
                keyValue: 5,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatAreas",
                keyColumn: "IdArea",
                keyValue: 6,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatAreas",
                keyColumn: "IdArea",
                keyValue: 7,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatAreas",
                keyColumn: "IdArea",
                keyValue: 8,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatEstatus",
                keyColumn: "IdEstatusRegistro",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatEstatus",
                keyColumn: "IdEstatusRegistro",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatGeneros",
                keyColumn: "IdGenero",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatGeneros",
                keyColumn: "IdGenero",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatPerfiles",
                keyColumn: "IdPerfil",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatPerfiles",
                keyColumn: "IdPerfil",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatPerfiles",
                keyColumn: "IdPerfil",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatPerfiles",
                keyColumn: "IdPerfil",
                keyValue: 4,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatPerfiles",
                keyColumn: "IdPerfil",
                keyValue: 5,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatRoles",
                keyColumn: "IdRol",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatRoles",
                keyColumn: "IdRol",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatRoles",
                keyColumn: "IdRol",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatRoles",
                keyColumn: "IdRol",
                keyValue: 4,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatTipoCentros",
                keyColumn: "IdTipoCentro",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatTipoCentros",
                keyColumn: "IdTipoCentro",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatTipoPago",
                keyColumn: "IdTipoPago",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatTipoPago",
                keyColumn: "IdTipoPago",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatTipoPago",
                keyColumn: "IdTipoPago",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatTipoPago",
                keyColumn: "IdTipoPago",
                keyValue: 4,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "CatTipoPago",
                keyColumn: "IdTipoPago",
                keyValue: 5,
                column: "FechaRegistro",
                value: new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
