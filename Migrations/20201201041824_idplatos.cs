using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurantee.Migrations
{
    public partial class idplatos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pedidoDetalles_plato_platoidPlatos",
                table: "pedidoDetalles");

            migrationBuilder.DropIndex(
                name: "IX_pedidoDetalles_platoidPlatos",
                table: "pedidoDetalles");

            migrationBuilder.DropColumn(
                name: "platoidPlatos",
                table: "pedidoDetalles");

            migrationBuilder.RenameColumn(
                name: "idPlato",
                table: "pedidoDetalles",
                newName: "idPlatos");

            migrationBuilder.CreateIndex(
                name: "IX_pedidoDetalles_idPlatos",
                table: "pedidoDetalles",
                column: "idPlatos");

            migrationBuilder.AddForeignKey(
                name: "FK_pedidoDetalles_plato_idPlatos",
                table: "pedidoDetalles",
                column: "idPlatos",
                principalTable: "plato",
                principalColumn: "idPlatos",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pedidoDetalles_plato_idPlatos",
                table: "pedidoDetalles");

            migrationBuilder.DropIndex(
                name: "IX_pedidoDetalles_idPlatos",
                table: "pedidoDetalles");

            migrationBuilder.RenameColumn(
                name: "idPlatos",
                table: "pedidoDetalles",
                newName: "idPlato");

            migrationBuilder.AddColumn<int>(
                name: "platoidPlatos",
                table: "pedidoDetalles",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_pedidoDetalles_platoidPlatos",
                table: "pedidoDetalles",
                column: "platoidPlatos");

            migrationBuilder.AddForeignKey(
                name: "FK_pedidoDetalles_plato_platoidPlatos",
                table: "pedidoDetalles",
                column: "platoidPlatos",
                principalTable: "plato",
                principalColumn: "idPlatos",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
