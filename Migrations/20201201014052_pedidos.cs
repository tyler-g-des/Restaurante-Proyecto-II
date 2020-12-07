using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurantee.Migrations
{
    public partial class pedidos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pedidos",
                columns: table => new
                {
                    idPedido = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    persona = table.Column<string>(nullable: true),
                    fechaPedido = table.Column<DateTime>(nullable: false),
                    idMesa = table.Column<int>(nullable: false),
                    observaciones = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pedidos", x => x.idPedido);
                    table.ForeignKey(
                        name: "FK_pedidos_mesas_idMesa",
                        column: x => x.idMesa,
                        principalTable: "mesas",
                        principalColumn: "idMesa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_pedidos_idMesa",
                table: "pedidos",
                column: "idMesa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pedidos");
        }
    }
}
