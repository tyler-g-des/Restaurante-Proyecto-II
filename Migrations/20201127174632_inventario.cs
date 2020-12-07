using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurantee.Migrations
{
    public partial class inventario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "inventarios",
                columns: table => new
                {
                    idInventario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ingrediente = table.Column<string>(nullable: true),
                    cantidad = table.Column<int>(nullable: false),
                    idClasificacionIngredientes = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventarios", x => x.idInventario);
                    table.ForeignKey(
                        name: "FK_inventarios_clasificacionIngredientes_idClasificacionIngredientes",
                        column: x => x.idClasificacionIngredientes,
                        principalTable: "clasificacionIngredientes",
                        principalColumn: "idClasificacionIngredientes",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_inventarios_idClasificacionIngredientes",
                table: "inventarios",
                column: "idClasificacionIngredientes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "inventarios");
        }
    }
}
