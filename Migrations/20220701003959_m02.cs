using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAdmin.Migrations
{
    public partial class m02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblCentros_CatTipoPago_CatTipoPagoIdTipoCentro",
                table: "TblCentros");

            migrationBuilder.RenameColumn(
                name: "CatTipoPagoIdTipoCentro",
                table: "TblCentros",
                newName: "CatTipoPagoIdTipoPago");

            migrationBuilder.RenameIndex(
                name: "IX_TblCentros_CatTipoPagoIdTipoCentro",
                table: "TblCentros",
                newName: "IX_TblCentros_CatTipoPagoIdTipoPago");

            migrationBuilder.RenameColumn(
                name: "TipoCentroDesc",
                table: "CatTipoPago",
                newName: "TipoPagoDesc");

            migrationBuilder.RenameColumn(
                name: "IdTipoCentro",
                table: "CatTipoPago",
                newName: "IdTipoPago");

            migrationBuilder.AddForeignKey(
                name: "FK_TblCentros_CatTipoPago_CatTipoPagoIdTipoPago",
                table: "TblCentros",
                column: "CatTipoPagoIdTipoPago",
                principalTable: "CatTipoPago",
                principalColumn: "IdTipoPago",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblCentros_CatTipoPago_CatTipoPagoIdTipoPago",
                table: "TblCentros");

            migrationBuilder.RenameColumn(
                name: "CatTipoPagoIdTipoPago",
                table: "TblCentros",
                newName: "CatTipoPagoIdTipoCentro");

            migrationBuilder.RenameIndex(
                name: "IX_TblCentros_CatTipoPagoIdTipoPago",
                table: "TblCentros",
                newName: "IX_TblCentros_CatTipoPagoIdTipoCentro");

            migrationBuilder.RenameColumn(
                name: "TipoPagoDesc",
                table: "CatTipoPago",
                newName: "TipoCentroDesc");

            migrationBuilder.RenameColumn(
                name: "IdTipoPago",
                table: "CatTipoPago",
                newName: "IdTipoCentro");

            migrationBuilder.AddForeignKey(
                name: "FK_TblCentros_CatTipoPago_CatTipoPagoIdTipoCentro",
                table: "TblCentros",
                column: "CatTipoPagoIdTipoCentro",
                principalTable: "CatTipoPago",
                principalColumn: "IdTipoCentro",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
