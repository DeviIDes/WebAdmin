using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAdmin.Migrations
{
    public partial class m02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CatEstatus",
                columns: table => new
                {
                    IdEstatusRegistro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstatusDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatEstatus", x => x.IdEstatusRegistro);
                });

            migrationBuilder.CreateTable(
                name: "CatGeneros",
                columns: table => new
                {
                    IdGenero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GeneroDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEstatusRegistro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatGeneros", x => x.IdGenero);
                });

            migrationBuilder.CreateTable(
                name: "CatPerfiles",
                columns: table => new
                {
                    IdPerfil = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PerfilDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEstatusRegistro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatPerfiles", x => x.IdPerfil);
                });

            migrationBuilder.CreateTable(
                name: "CatRoles",
                columns: table => new
                {
                    IdRol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RolDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEstatusRegistro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatRoles", x => x.IdRol);
                });

            migrationBuilder.CreateTable(
                name: "TblCentros",
                columns: table => new
                {
                    IdCentro = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NombreCentro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoPostal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdColonia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Colonia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalidadMunicipio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdEmpresa = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEstatusRegistro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCentros", x => x.IdCentro);
                });

            migrationBuilder.CreateTable(
                name: "TblEmpresa",
                columns: table => new
                {
                    IdEmpresa = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NombreEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rfc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiroComercial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Calle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoPostal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdColonia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Colonia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalidadMunicipio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaRegistro = table.Column<DateTime>(name: "Fecha Registro", type: "datetime2", nullable: false),
                    IdEstatusRegistro = table.Column<int>(type: "int", nullable: false),
                    CatEstatusIdEstatusRegistro = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblEmpresa", x => x.IdEmpresa);
                    table.ForeignKey(
                        name: "FK_TblEmpresa_CatEstatus_CatEstatusIdEstatusRegistro",
                        column: x => x.CatEstatusIdEstatusRegistro,
                        principalTable: "CatEstatus",
                        principalColumn: "IdEstatusRegistro",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatAreas",
                columns: table => new
                {
                    IdArea = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdEmpresa = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEstatusRegistro = table.Column<int>(type: "int", nullable: false),
                    IdEmpresaNavigationIdEmpresaNavigationIdEmpresa = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatAreas", x => x.IdArea);
                    table.ForeignKey(
                        name: "FK_CatAreas_TblEmpresa_IdEmpresaNavigationIdEmpresaNavigationIdEmpresa",
                        column: x => x.IdEmpresaNavigationIdEmpresaNavigationIdEmpresa,
                        principalTable: "TblEmpresa",
                        principalColumn: "IdEmpresa",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblUsuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApellidoPaterno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApellidoMaterno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdEmpresa = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NombreEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdArea = table.Column<int>(type: "int", nullable: false),
                    IdGenero = table.Column<int>(type: "int", nullable: false),
                    IdPerfil = table.Column<int>(type: "int", nullable: false),
                    IdRol = table.Column<int>(type: "int", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CorreoAcceso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEstatusRegistro = table.Column<int>(type: "int", nullable: false),
                    IdAreaNavigationIdArea = table.Column<int>(type: "int", nullable: true),
                    IdGeneroNavigationIdGenero = table.Column<int>(type: "int", nullable: true),
                    IdPerfilNavigationIdPerfil = table.Column<int>(type: "int", nullable: true),
                    IdRolNavigationIdRol = table.Column<int>(type: "int", nullable: true),
                    CatAreaIdArea = table.Column<int>(type: "int", nullable: true),
                    CatGeneroIdGenero = table.Column<int>(type: "int", nullable: true),
                    CatPerfilIdPerfil = table.Column<int>(type: "int", nullable: true),
                    CatRoleIdRol = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblUsuarios", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_TblUsuarios_CatAreas_CatAreaIdArea",
                        column: x => x.CatAreaIdArea,
                        principalTable: "CatAreas",
                        principalColumn: "IdArea",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblUsuarios_CatGeneros_CatGeneroIdGenero",
                        column: x => x.CatGeneroIdGenero,
                        principalTable: "CatGeneros",
                        principalColumn: "IdGenero",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblUsuarios_CatPerfiles_CatPerfilIdPerfil",
                        column: x => x.CatPerfilIdPerfil,
                        principalTable: "CatPerfiles",
                        principalColumn: "IdPerfil",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblUsuarios_CatRoles_CatRoleIdRol",
                        column: x => x.CatRoleIdRol,
                        principalTable: "CatRoles",
                        principalColumn: "IdRol",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CatAreas_IdEmpresaNavigationIdEmpresaNavigationIdEmpresa",
                table: "CatAreas",
                column: "IdEmpresaNavigationIdEmpresaNavigationIdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_TblEmpresa_CatEstatusIdEstatusRegistro",
                table: "TblEmpresa",
                column: "CatEstatusIdEstatusRegistro");

            migrationBuilder.CreateIndex(
                name: "IX_TblUsuarios_CatAreaIdArea",
                table: "TblUsuarios",
                column: "CatAreaIdArea");

            migrationBuilder.CreateIndex(
                name: "IX_TblUsuarios_CatGeneroIdGenero",
                table: "TblUsuarios",
                column: "CatGeneroIdGenero");

            migrationBuilder.CreateIndex(
                name: "IX_TblUsuarios_CatPerfilIdPerfil",
                table: "TblUsuarios",
                column: "CatPerfilIdPerfil");

            migrationBuilder.CreateIndex(
                name: "IX_TblUsuarios_CatRoleIdRol",
                table: "TblUsuarios",
                column: "CatRoleIdRol");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblCentros");

            migrationBuilder.DropTable(
                name: "TblUsuarios");

            migrationBuilder.DropTable(
                name: "CatAreas");

            migrationBuilder.DropTable(
                name: "CatGeneros");

            migrationBuilder.DropTable(
                name: "CatPerfiles");

            migrationBuilder.DropTable(
                name: "CatRoles");

            migrationBuilder.DropTable(
                name: "TblEmpresa");

            migrationBuilder.DropTable(
                name: "CatEstatus");
        }
    }
}
