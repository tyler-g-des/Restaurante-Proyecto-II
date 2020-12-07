using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurantee.Migrations
{
    public partial class pedidopedidoDetalle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "impuesto",
                table: "pedidos",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "subTotal",
                table: "pedidos",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "total",
                table: "pedidos",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "pedidoDetalles",
                columns: table => new
                {
                    idPedidoDetalle = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    cantidad = table.Column<int>(nullable: false),
                    subTotal = table.Column<decimal>(nullable: false),
                    impuesto = table.Column<decimal>(nullable: false),
                    total = table.Column<decimal>(nullable: false),
                    idPedido = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pedidoDetalles", x => x.idPedidoDetalle);
                    table.ForeignKey(
                        name: "FK_pedidoDetalles_pedidos_idPedido",
                        column: x => x.idPedido,
                        principalTable: "pedidos",
                        principalColumn: "idPedido",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "plato",
                columns: table => new
                {
                    idPlatos = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Precio = table.Column<int>(nullable: false),
                    Cantidad = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_plato", x => x.idPlatos);
                });

            migrationBuilder.CreateIndex(
                name: "IX_pedidoDetalles_idPedido",
                table: "pedidoDetalles",
                column: "idPedido");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pedidoDetalles");

            migrationBuilder.DropTable(
                name: "plato");

            migrationBuilder.DropColumn(
                name: "impuesto",
                table: "pedidos");

            migrationBuilder.DropColumn(
                name: "subTotal",
                table: "pedidos");

            migrationBuilder.DropColumn(
                name: "total",
                table: "pedidos");
        }
    }
}
