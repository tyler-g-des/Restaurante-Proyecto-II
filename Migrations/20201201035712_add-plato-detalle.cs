using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurantee.Migrations
{
    public partial class addplatodetalle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "idPlato",
                table: "pedidoDetalles",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pedidoDetalles_plato_platoidPlatos",
                table: "pedidoDetalles");

            migrationBuilder.DropIndex(
                name: "IX_pedidoDetalles_platoidPlatos",
                table: "pedidoDetalles");

            migrationBuilder.DropColumn(
                name: "idPlato",
                table: "pedidoDetalles");

            migrationBuilder.DropColumn(
                name: "platoidPlatos",
                table: "pedidoDetalles");
        }
    }
}
