using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAdmin.Migrations
{
    public partial class m01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatCodigosPostales",
                columns: table => new
                {
                    IdCodigosPostales = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dcodigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dasenta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DtipoAsenta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dmnpio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Destado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dcp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cestado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Coficina = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ccp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CtipoAsenta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cmnpio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdAsentaCpcons = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dzona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CcveCiudad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatCodigosPostales", x => x.IdCodigosPostales);
                });

            migrationBuilder.CreateTable(
                name: "CatTipoCentros",
                columns: table => new
                {
                    IdTipoCentro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoCentroDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEstatusRegistro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatTipoCentros", x => x.IdTipoCentro);
                });

            migrationBuilder.CreateTable(
                name: "FilesOnDatabase",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UploadedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilesOnDatabase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FilesOnFileSystem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UploadedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilesOnFileSystem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    IdCorporativo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NombreEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdArea = table.Column<int>(type: "int", nullable: false),
                    IdGenero = table.Column<int>(type: "int", nullable: false),
                    IdPerfil = table.Column<int>(type: "int", nullable: false),
                    IdRol = table.Column<int>(type: "int", nullable: false),
                    FechadeNacimiento = table.Column<DateTime>(name: "Fecha de Nacimiento", type: "datetime2", nullable: false),
                    CorreoAcceso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEstatusRegistro = table.Column<int>(type: "int", nullable: false),
                    CatAreaIdArea = table.Column<int>(type: "int", nullable: true),
                    CatEscolaridadIdEscolaridad = table.Column<int>(type: "int", nullable: true),
                    CatGeneroIdGenero = table.Column<int>(type: "int", nullable: true),
                    CatNivelEscolarIdNivelEscolar = table.Column<int>(type: "int", nullable: true),
                    CatPerfilIdPerfil = table.Column<int>(type: "int", nullable: true),
                    CatRoleIdRol = table.Column<int>(type: "int", nullable: true),
                    CatTipoAlumnoIdTipoAlumno = table.Column<int>(type: "int", nullable: true),
                    CatTipoContratacionIdTipoContratacion = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblUsuarios", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "CatProductos",
                columns: table => new
                {
                    IdProducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoInterno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoExterno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdCategoria = table.Column<int>(type: "int", nullable: false),
                    DescProducto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CantidadMinima = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    ProductoPrecioUno = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PorcentajePrecioUno = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SubCosto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Costo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEstatusRegistro = table.Column<int>(type: "int", nullable: false),
                    CatCategoriaIdCategoria = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatProductos", x => x.IdProducto);
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
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEstatusRegistro = table.Column<int>(type: "int", nullable: false),
                    CatEstatusIdEstatusRegistro = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblEmpresa", x => x.IdEmpresa);
                });

            migrationBuilder.CreateTable(
                name: "TblCorporativos",
                columns: table => new
                {
                    IdCorporativo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdTipoLicencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdTipoCorporativo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreCorporativo = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    IdEstatusRegistro = table.Column<int>(type: "int", nullable: false),
                    TblEmpresaIdEmpresa = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCorporativos", x => x.IdCorporativo);
                    table.ForeignKey(
                        name: "FK_TblCorporativos_TblEmpresa_TblEmpresaIdEmpresa",
                        column: x => x.TblEmpresaIdEmpresa,
                        principalTable: "TblEmpresa",
                        principalColumn: "IdEmpresa",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatAreas",
                columns: table => new
                {
                    IdArea = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdCorporativo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEstatusRegistro = table.Column<int>(type: "int", nullable: false),
                    TblCorporativoIdCorporativo = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatAreas", x => x.IdArea);
                    table.ForeignKey(
                        name: "FK_CatAreas_TblCorporativos_TblCorporativoIdCorporativo",
                        column: x => x.TblCorporativoIdCorporativo,
                        principalTable: "TblCorporativos",
                        principalColumn: "IdCorporativo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatCategorias",
                columns: table => new
                {
                    IdCategoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoriaDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEstatusRegistro = table.Column<int>(type: "int", nullable: false),
                    TblCorporativoIdCorporativo = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatCategorias", x => x.IdCategoria);
                    table.ForeignKey(
                        name: "FK_CatCategorias_TblCorporativos_TblCorporativoIdCorporativo",
                        column: x => x.TblCorporativoIdCorporativo,
                        principalTable: "TblCorporativos",
                        principalColumn: "IdCorporativo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatEscolaridad",
                columns: table => new
                {
                    IdEscolaridad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EscolaridadDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEstatusRegistro = table.Column<int>(type: "int", nullable: false),
                    TblCorporativoIdCorporativo = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatEscolaridad", x => x.IdEscolaridad);
                    table.ForeignKey(
                        name: "FK_CatEscolaridad_TblCorporativos_TblCorporativoIdCorporativo",
                        column: x => x.TblCorporativoIdCorporativo,
                        principalTable: "TblCorporativos",
                        principalColumn: "IdCorporativo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatEstatus",
                columns: table => new
                {
                    IdEstatusRegistro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstatusDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TblCorporativoIdCorporativo = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatEstatus", x => x.IdEstatusRegistro);
                    table.ForeignKey(
                        name: "FK_CatEstatus_TblCorporativos_TblCorporativoIdCorporativo",
                        column: x => x.TblCorporativoIdCorporativo,
                        principalTable: "TblCorporativos",
                        principalColumn: "IdCorporativo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatGeneros",
                columns: table => new
                {
                    IdGenero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GeneroDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEstatusRegistro = table.Column<int>(type: "int", nullable: false),
                    TblCorporativoIdCorporativo = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatGeneros", x => x.IdGenero);
                    table.ForeignKey(
                        name: "FK_CatGeneros_TblCorporativos_TblCorporativoIdCorporativo",
                        column: x => x.TblCorporativoIdCorporativo,
                        principalTable: "TblCorporativos",
                        principalColumn: "IdCorporativo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatNivelEscolar",
                columns: table => new
                {
                    IdNivelEscolar = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NivelEscolarDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEstatusRegistro = table.Column<int>(type: "int", nullable: false),
                    TblCorporativoIdCorporativo = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatNivelEscolar", x => x.IdNivelEscolar);
                    table.ForeignKey(
                        name: "FK_CatNivelEscolar_TblCorporativos_TblCorporativoIdCorporativo",
                        column: x => x.TblCorporativoIdCorporativo,
                        principalTable: "TblCorporativos",
                        principalColumn: "IdCorporativo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatPerfiles",
                columns: table => new
                {
                    IdPerfil = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PerfilDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEstatusRegistro = table.Column<int>(type: "int", nullable: false),
                    TblCorporativoIdCorporativo = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatPerfiles", x => x.IdPerfil);
                    table.ForeignKey(
                        name: "FK_CatPerfiles_TblCorporativos_TblCorporativoIdCorporativo",
                        column: x => x.TblCorporativoIdCorporativo,
                        principalTable: "TblCorporativos",
                        principalColumn: "IdCorporativo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatRoles",
                columns: table => new
                {
                    IdRol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RolDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEstatusRegistro = table.Column<int>(type: "int", nullable: false),
                    TblCorporativoIdCorporativo = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatRoles", x => x.IdRol);
                    table.ForeignKey(
                        name: "FK_CatRoles_TblCorporativos_TblCorporativoIdCorporativo",
                        column: x => x.TblCorporativoIdCorporativo,
                        principalTable: "TblCorporativos",
                        principalColumn: "IdCorporativo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatTipoAlumno",
                columns: table => new
                {
                    IdTipoAlumno = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoAlumnoDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEstatusRegistro = table.Column<int>(type: "int", nullable: false),
                    TblCorporativoIdCorporativo = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatTipoAlumno", x => x.IdTipoAlumno);
                    table.ForeignKey(
                        name: "FK_CatTipoAlumno_TblCorporativos_TblCorporativoIdCorporativo",
                        column: x => x.TblCorporativoIdCorporativo,
                        principalTable: "TblCorporativos",
                        principalColumn: "IdCorporativo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatTipoCentroTblCorporativo",
                columns: table => new
                {
                    CatTipoCentrosIdTipoCentro = table.Column<int>(type: "int", nullable: false),
                    TblCorporativosIdCorporativo = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatTipoCentroTblCorporativo", x => new { x.CatTipoCentrosIdTipoCentro, x.TblCorporativosIdCorporativo });
                    table.ForeignKey(
                        name: "FK_CatTipoCentroTblCorporativo_CatTipoCentros_CatTipoCentrosIdTipoCentro",
                        column: x => x.CatTipoCentrosIdTipoCentro,
                        principalTable: "CatTipoCentros",
                        principalColumn: "IdTipoCentro",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CatTipoCentroTblCorporativo_TblCorporativos_TblCorporativosIdCorporativo",
                        column: x => x.TblCorporativosIdCorporativo,
                        principalTable: "TblCorporativos",
                        principalColumn: "IdCorporativo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CatTipoContratacion",
                columns: table => new
                {
                    IdTipoContratacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoContratacionDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEstatusRegistro = table.Column<int>(type: "int", nullable: false),
                    TblCorporativoIdCorporativo = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatTipoContratacion", x => x.IdTipoContratacion);
                    table.ForeignKey(
                        name: "FK_CatTipoContratacion_TblCorporativos_TblCorporativoIdCorporativo",
                        column: x => x.TblCorporativoIdCorporativo,
                        principalTable: "TblCorporativos",
                        principalColumn: "IdCorporativo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatTipoDirecciones",
                columns: table => new
                {
                    IdTipoDireccion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoDireccionDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEstatusRegistro = table.Column<int>(type: "int", nullable: false),
                    TblCorporativoIdCorporativo = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatTipoDirecciones", x => x.IdTipoDireccion);
                    table.ForeignKey(
                        name: "FK_CatTipoDirecciones_TblCorporativos_TblCorporativoIdCorporativo",
                        column: x => x.TblCorporativoIdCorporativo,
                        principalTable: "TblCorporativos",
                        principalColumn: "IdCorporativo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatTipoPago",
                columns: table => new
                {
                    IdTipoPago = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoPagoDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEstatusRegistro = table.Column<int>(type: "int", nullable: false),
                    TblCorporativoIdCorporativo = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatTipoPago", x => x.IdTipoPago);
                    table.ForeignKey(
                        name: "FK_CatTipoPago_TblCorporativos_TblCorporativoIdCorporativo",
                        column: x => x.TblCorporativoIdCorporativo,
                        principalTable: "TblCorporativos",
                        principalColumn: "IdCorporativo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatTipoPrestamo",
                columns: table => new
                {
                    IdTipoPrestamo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoPrestamoDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEstatusRegistro = table.Column<int>(type: "int", nullable: false),
                    TblCorporativoIdCorporativo = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatTipoPrestamo", x => x.IdTipoPrestamo);
                    table.ForeignKey(
                        name: "FK_CatTipoPrestamo_TblCorporativos_TblCorporativoIdCorporativo",
                        column: x => x.TblCorporativoIdCorporativo,
                        principalTable: "TblCorporativos",
                        principalColumn: "IdCorporativo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatTipoServicio",
                columns: table => new
                {
                    IdTipoServicio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoServicioDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEstatusRegistro = table.Column<int>(type: "int", nullable: false),
                    TblCorporativoIdCorporativo = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatTipoServicio", x => x.IdTipoServicio);
                    table.ForeignKey(
                        name: "FK_CatTipoServicio_TblCorporativos_TblCorporativoIdCorporativo",
                        column: x => x.TblCorporativoIdCorporativo,
                        principalTable: "TblCorporativos",
                        principalColumn: "IdCorporativo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblClientes",
                columns: table => new
                {
                    IdCliente = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NombreCliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rfc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiroComercial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdCorporativo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEstatusRegistro = table.Column<int>(type: "int", nullable: false),
                    TblCorporativoIdCorporativo = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblClientes", x => x.IdCliente);
                    table.ForeignKey(
                        name: "FK_TblClientes_TblCorporativos_TblCorporativoIdCorporativo",
                        column: x => x.TblCorporativoIdCorporativo,
                        principalTable: "TblCorporativos",
                        principalColumn: "IdCorporativo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblProveedores",
                columns: table => new
                {
                    IdProveedor = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NombreProveedor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rfc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiroComercial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdCorporativo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEstatusRegistro = table.Column<int>(type: "int", nullable: false),
                    TblCorporativoIdCorporativo = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblProveedores", x => x.IdProveedor);
                    table.ForeignKey(
                        name: "FK_TblProveedores_TblCorporativos_TblCorporativoIdCorporativo",
                        column: x => x.TblCorporativoIdCorporativo,
                        principalTable: "TblCorporativos",
                        principalColumn: "IdCorporativo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblCentros",
                columns: table => new
                {
                    IdCentro = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdTipoLicencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdTipoCentro = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    IdCorporativo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEstatusRegistro = table.Column<int>(type: "int", nullable: false),
                    CatTipoPagoIdTipoPago = table.Column<int>(type: "int", nullable: true),
                    CatTipoServicioIdTipoServicio = table.Column<int>(type: "int", nullable: true),
                    TblCorporativoIdCorporativo = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCentros", x => x.IdCentro);
                    table.ForeignKey(
                        name: "FK_TblCentros_CatTipoPago_CatTipoPagoIdTipoPago",
                        column: x => x.CatTipoPagoIdTipoPago,
                        principalTable: "CatTipoPago",
                        principalColumn: "IdTipoPago",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblCentros_CatTipoServicio_CatTipoServicioIdTipoServicio",
                        column: x => x.CatTipoServicioIdTipoServicio,
                        principalTable: "CatTipoServicio",
                        principalColumn: "IdTipoServicio",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblCentros_TblCorporativos_TblCorporativoIdCorporativo",
                        column: x => x.TblCorporativoIdCorporativo,
                        principalTable: "TblCorporativos",
                        principalColumn: "IdCorporativo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblClienteContactos",
                columns: table => new
                {
                    IdClienteContacto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPerfil = table.Column<int>(type: "int", nullable: false),
                    NombreClienteContacto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelefonoMovil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdCliente = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEstatusRegistro = table.Column<int>(type: "int", nullable: false),
                    TblClienteIdCliente = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblClienteContactos", x => x.IdClienteContacto);
                    table.ForeignKey(
                        name: "FK_TblClienteContactos_TblClientes_TblClienteIdCliente",
                        column: x => x.TblClienteIdCliente,
                        principalTable: "TblClientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblClienteDirecciones",
                columns: table => new
                {
                    IdClienteDirecciones = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTipoDireccion = table.Column<int>(type: "int", nullable: false),
                    Calle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoPostal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdColonia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Colonia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalidadMunicipio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdCliente = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEstatusRegistro = table.Column<int>(type: "int", nullable: false),
                    TblClienteIdCliente = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblClienteDirecciones", x => x.IdClienteDirecciones);
                    table.ForeignKey(
                        name: "FK_TblClienteDirecciones_TblClientes_TblClienteIdCliente",
                        column: x => x.TblClienteIdCliente,
                        principalTable: "TblClientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblProveedorContactos",
                columns: table => new
                {
                    IdProveedorContacto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPerfil = table.Column<int>(type: "int", nullable: false),
                    NombreProveedorContacto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelefonoMovil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdProveedor = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEstatusRegistro = table.Column<int>(type: "int", nullable: false),
                    TblProveedorIdProveedor = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblProveedorContactos", x => x.IdProveedorContacto);
                    table.ForeignKey(
                        name: "FK_TblProveedorContactos_TblProveedores_TblProveedorIdProveedor",
                        column: x => x.TblProveedorIdProveedor,
                        principalTable: "TblProveedores",
                        principalColumn: "IdProveedor",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblProveedorDirecciones",
                columns: table => new
                {
                    IdProveedorDirecciones = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTipoDireccion = table.Column<int>(type: "int", nullable: false),
                    Calle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoPostal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdColonia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Colonia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalidadMunicipio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdProveedor = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEstatusRegistro = table.Column<int>(type: "int", nullable: false),
                    TblProveedorIdProveedor = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblProveedorDirecciones", x => x.IdProveedorDirecciones);
                    table.ForeignKey(
                        name: "FK_TblProveedorDirecciones_TblProveedores_TblProveedorIdProveedor",
                        column: x => x.TblProveedorIdProveedor,
                        principalTable: "TblProveedores",
                        principalColumn: "IdProveedor",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CatAreas_TblCorporativoIdCorporativo",
                table: "CatAreas",
                column: "TblCorporativoIdCorporativo");

            migrationBuilder.CreateIndex(
                name: "IX_CatCategorias_TblCorporativoIdCorporativo",
                table: "CatCategorias",
                column: "TblCorporativoIdCorporativo");

            migrationBuilder.CreateIndex(
                name: "IX_CatEscolaridad_TblCorporativoIdCorporativo",
                table: "CatEscolaridad",
                column: "TblCorporativoIdCorporativo");

            migrationBuilder.CreateIndex(
                name: "IX_CatEstatus_TblCorporativoIdCorporativo",
                table: "CatEstatus",
                column: "TblCorporativoIdCorporativo");

            migrationBuilder.CreateIndex(
                name: "IX_CatGeneros_TblCorporativoIdCorporativo",
                table: "CatGeneros",
                column: "TblCorporativoIdCorporativo");

            migrationBuilder.CreateIndex(
                name: "IX_CatNivelEscolar_TblCorporativoIdCorporativo",
                table: "CatNivelEscolar",
                column: "TblCorporativoIdCorporativo");

            migrationBuilder.CreateIndex(
                name: "IX_CatPerfiles_TblCorporativoIdCorporativo",
                table: "CatPerfiles",
                column: "TblCorporativoIdCorporativo");

            migrationBuilder.CreateIndex(
                name: "IX_CatProductos_CatCategoriaIdCategoria",
                table: "CatProductos",
                column: "CatCategoriaIdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_CatRoles_TblCorporativoIdCorporativo",
                table: "CatRoles",
                column: "TblCorporativoIdCorporativo");

            migrationBuilder.CreateIndex(
                name: "IX_CatTipoAlumno_TblCorporativoIdCorporativo",
                table: "CatTipoAlumno",
                column: "TblCorporativoIdCorporativo");

            migrationBuilder.CreateIndex(
                name: "IX_CatTipoCentroTblCorporativo_TblCorporativosIdCorporativo",
                table: "CatTipoCentroTblCorporativo",
                column: "TblCorporativosIdCorporativo");

            migrationBuilder.CreateIndex(
                name: "IX_CatTipoContratacion_TblCorporativoIdCorporativo",
                table: "CatTipoContratacion",
                column: "TblCorporativoIdCorporativo");

            migrationBuilder.CreateIndex(
                name: "IX_CatTipoDirecciones_TblCorporativoIdCorporativo",
                table: "CatTipoDirecciones",
                column: "TblCorporativoIdCorporativo");

            migrationBuilder.CreateIndex(
                name: "IX_CatTipoPago_TblCorporativoIdCorporativo",
                table: "CatTipoPago",
                column: "TblCorporativoIdCorporativo");

            migrationBuilder.CreateIndex(
                name: "IX_CatTipoPrestamo_TblCorporativoIdCorporativo",
                table: "CatTipoPrestamo",
                column: "TblCorporativoIdCorporativo");

            migrationBuilder.CreateIndex(
                name: "IX_CatTipoServicio_TblCorporativoIdCorporativo",
                table: "CatTipoServicio",
                column: "TblCorporativoIdCorporativo");

            migrationBuilder.CreateIndex(
                name: "IX_TblCentros_CatTipoPagoIdTipoPago",
                table: "TblCentros",
                column: "CatTipoPagoIdTipoPago");

            migrationBuilder.CreateIndex(
                name: "IX_TblCentros_CatTipoServicioIdTipoServicio",
                table: "TblCentros",
                column: "CatTipoServicioIdTipoServicio");

            migrationBuilder.CreateIndex(
                name: "IX_TblCentros_TblCorporativoIdCorporativo",
                table: "TblCentros",
                column: "TblCorporativoIdCorporativo");

            migrationBuilder.CreateIndex(
                name: "IX_TblClienteContactos_TblClienteIdCliente",
                table: "TblClienteContactos",
                column: "TblClienteIdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_TblClienteDirecciones_TblClienteIdCliente",
                table: "TblClienteDirecciones",
                column: "TblClienteIdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_TblClientes_TblCorporativoIdCorporativo",
                table: "TblClientes",
                column: "TblCorporativoIdCorporativo");

            migrationBuilder.CreateIndex(
                name: "IX_TblCorporativos_TblEmpresaIdEmpresa",
                table: "TblCorporativos",
                column: "TblEmpresaIdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_TblEmpresa_CatEstatusIdEstatusRegistro",
                table: "TblEmpresa",
                column: "CatEstatusIdEstatusRegistro");

            migrationBuilder.CreateIndex(
                name: "IX_TblProveedorContactos_TblProveedorIdProveedor",
                table: "TblProveedorContactos",
                column: "TblProveedorIdProveedor");

            migrationBuilder.CreateIndex(
                name: "IX_TblProveedorDirecciones_TblProveedorIdProveedor",
                table: "TblProveedorDirecciones",
                column: "TblProveedorIdProveedor");

            migrationBuilder.CreateIndex(
                name: "IX_TblProveedores_TblCorporativoIdCorporativo",
                table: "TblProveedores",
                column: "TblCorporativoIdCorporativo");

            migrationBuilder.CreateIndex(
                name: "IX_TblUsuarios_CatAreaIdArea",
                table: "TblUsuarios",
                column: "CatAreaIdArea");

            migrationBuilder.CreateIndex(
                name: "IX_TblUsuarios_CatEscolaridadIdEscolaridad",
                table: "TblUsuarios",
                column: "CatEscolaridadIdEscolaridad");

            migrationBuilder.CreateIndex(
                name: "IX_TblUsuarios_CatGeneroIdGenero",
                table: "TblUsuarios",
                column: "CatGeneroIdGenero");

            migrationBuilder.CreateIndex(
                name: "IX_TblUsuarios_CatNivelEscolarIdNivelEscolar",
                table: "TblUsuarios",
                column: "CatNivelEscolarIdNivelEscolar");

            migrationBuilder.CreateIndex(
                name: "IX_TblUsuarios_CatPerfilIdPerfil",
                table: "TblUsuarios",
                column: "CatPerfilIdPerfil");

            migrationBuilder.CreateIndex(
                name: "IX_TblUsuarios_CatRoleIdRol",
                table: "TblUsuarios",
                column: "CatRoleIdRol");

            migrationBuilder.CreateIndex(
                name: "IX_TblUsuarios_CatTipoAlumnoIdTipoAlumno",
                table: "TblUsuarios",
                column: "CatTipoAlumnoIdTipoAlumno");

            migrationBuilder.CreateIndex(
                name: "IX_TblUsuarios_CatTipoContratacionIdTipoContratacion",
                table: "TblUsuarios",
                column: "CatTipoContratacionIdTipoContratacion");

            migrationBuilder.AddForeignKey(
                name: "FK_TblUsuarios_CatAreas_CatAreaIdArea",
                table: "TblUsuarios",
                column: "CatAreaIdArea",
                principalTable: "CatAreas",
                principalColumn: "IdArea",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblUsuarios_CatEscolaridad_CatEscolaridadIdEscolaridad",
                table: "TblUsuarios",
                column: "CatEscolaridadIdEscolaridad",
                principalTable: "CatEscolaridad",
                principalColumn: "IdEscolaridad",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblUsuarios_CatGeneros_CatGeneroIdGenero",
                table: "TblUsuarios",
                column: "CatGeneroIdGenero",
                principalTable: "CatGeneros",
                principalColumn: "IdGenero",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblUsuarios_CatNivelEscolar_CatNivelEscolarIdNivelEscolar",
                table: "TblUsuarios",
                column: "CatNivelEscolarIdNivelEscolar",
                principalTable: "CatNivelEscolar",
                principalColumn: "IdNivelEscolar",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblUsuarios_CatPerfiles_CatPerfilIdPerfil",
                table: "TblUsuarios",
                column: "CatPerfilIdPerfil",
                principalTable: "CatPerfiles",
                principalColumn: "IdPerfil",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblUsuarios_CatRoles_CatRoleIdRol",
                table: "TblUsuarios",
                column: "CatRoleIdRol",
                principalTable: "CatRoles",
                principalColumn: "IdRol",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblUsuarios_CatTipoAlumno_CatTipoAlumnoIdTipoAlumno",
                table: "TblUsuarios",
                column: "CatTipoAlumnoIdTipoAlumno",
                principalTable: "CatTipoAlumno",
                principalColumn: "IdTipoAlumno",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblUsuarios_CatTipoContratacion_CatTipoContratacionIdTipoContratacion",
                table: "TblUsuarios",
                column: "CatTipoContratacionIdTipoContratacion",
                principalTable: "CatTipoContratacion",
                principalColumn: "IdTipoContratacion",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatProductos_CatCategorias_CatCategoriaIdCategoria",
                table: "CatProductos",
                column: "CatCategoriaIdCategoria",
                principalTable: "CatCategorias",
                principalColumn: "IdCategoria",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblEmpresa_CatEstatus_CatEstatusIdEstatusRegistro",
                table: "TblEmpresa",
                column: "CatEstatusIdEstatusRegistro",
                principalTable: "CatEstatus",
                principalColumn: "IdEstatusRegistro",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CatEstatus_TblCorporativos_TblCorporativoIdCorporativo",
                table: "CatEstatus");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CatCodigosPostales");

            migrationBuilder.DropTable(
                name: "CatProductos");

            migrationBuilder.DropTable(
                name: "CatTipoCentroTblCorporativo");

            migrationBuilder.DropTable(
                name: "CatTipoDirecciones");

            migrationBuilder.DropTable(
                name: "CatTipoPrestamo");

            migrationBuilder.DropTable(
                name: "FilesOnDatabase");

            migrationBuilder.DropTable(
                name: "FilesOnFileSystem");

            migrationBuilder.DropTable(
                name: "TblCentros");

            migrationBuilder.DropTable(
                name: "TblClienteContactos");

            migrationBuilder.DropTable(
                name: "TblClienteDirecciones");

            migrationBuilder.DropTable(
                name: "TblProveedorContactos");

            migrationBuilder.DropTable(
                name: "TblProveedorDirecciones");

            migrationBuilder.DropTable(
                name: "TblUsuarios");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "CatCategorias");

            migrationBuilder.DropTable(
                name: "CatTipoCentros");

            migrationBuilder.DropTable(
                name: "CatTipoPago");

            migrationBuilder.DropTable(
                name: "CatTipoServicio");

            migrationBuilder.DropTable(
                name: "TblClientes");

            migrationBuilder.DropTable(
                name: "TblProveedores");

            migrationBuilder.DropTable(
                name: "CatAreas");

            migrationBuilder.DropTable(
                name: "CatEscolaridad");

            migrationBuilder.DropTable(
                name: "CatGeneros");

            migrationBuilder.DropTable(
                name: "CatNivelEscolar");

            migrationBuilder.DropTable(
                name: "CatPerfiles");

            migrationBuilder.DropTable(
                name: "CatRoles");

            migrationBuilder.DropTable(
                name: "CatTipoAlumno");

            migrationBuilder.DropTable(
                name: "CatTipoContratacion");

            migrationBuilder.DropTable(
                name: "TblCorporativos");

            migrationBuilder.DropTable(
                name: "TblEmpresa");

            migrationBuilder.DropTable(
                name: "CatEstatus");
        }
    }
}
