using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurantee.Migrations
{
    public partial class ajustes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "idPlato",
                table: "pedidos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "platoidPlatos",
                table: "pedidos",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "precio",
                table: "pedidoDetalles",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_pedidos_platoidPlatos",
                table: "pedidos",
                column: "platoidPlatos");

            migrationBuilder.AddForeignKey(
                name: "FK_pedidos_plato_platoidPlatos",
                table: "pedidos",
                column: "platoidPlatos",
                principalTable: "plato",
                principalColumn: "idPlatos",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pedidos_plato_platoidPlatos",
                table: "pedidos");

            migrationBuilder.DropIndex(
                name: "IX_pedidos_platoidPlatos",
                table: "pedidos");

            migrationBuilder.DropColumn(
                name: "idPlato",
                table: "pedidos");

            migrationBuilder.DropColumn(
                name: "platoidPlatos",
                table: "pedidos");

            migrationBuilder.DropColumn(
                name: "precio",
                table: "pedidoDetalles");
        }
    }
}
