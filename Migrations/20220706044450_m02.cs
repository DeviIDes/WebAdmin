using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAdmin.Migrations
{
    public partial class m02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RelVentaProducto",
                columns: table => new
                {
                    IdRelVentaProducto = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCategoria = table.Column<int>(type: "int", nullable: false),
                    IdProducto = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    ProductoPrecioUno = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdVenta = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdUsuarioModifico = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEstatusRegistro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelVentaProducto", x => x.IdRelVentaProducto);
                });

            migrationBuilder.CreateTable(
                name: "RelVentasPagos",
                columns: table => new
                {
                    IdRelVentasPago = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CodigoReferencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CantidadPago = table.Column<int>(type: "int", nullable: false),
                    IdVenta = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdUsuarioModifico = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEstatusRegistro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelVentasPagos", x => x.IdRelVentasPago);
                });

            migrationBuilder.CreateTable(
                name: "TblVenta",
                columns: table => new
                {
                    IdVenta = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumeroVenta = table.Column<int>(type: "int", nullable: false),
                    IdUsuarioVenta = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCentro = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCliente = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descuento = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdTipoPago = table.Column<int>(type: "int", nullable: false),
                    FechaAlterna = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuarioModifico = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEstatusRegistro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblVenta", x => x.IdVenta);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RelVentaProducto");

            migrationBuilder.DropTable(
                name: "RelVentasPagos");

            migrationBuilder.DropTable(
                name: "TblVenta");
        }
    }
}
