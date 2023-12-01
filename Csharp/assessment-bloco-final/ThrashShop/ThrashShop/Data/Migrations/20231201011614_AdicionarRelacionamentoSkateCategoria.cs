using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThrashShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarRelacionamentoSkateCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoriaSkate",
                columns: table => new
                {
                    CategoriasCategoriaId = table.Column<int>(type: "int", nullable: false),
                    SkatesSkateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaSkate", x => new { x.CategoriasCategoriaId, x.SkatesSkateId });
                    table.ForeignKey(
                        name: "FK_CategoriaSkate_Categorias_CategoriasCategoriaId",
                        column: x => x.CategoriasCategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriaSkate_TB_SKATE_SkatesSkateId",
                        column: x => x.SkatesSkateId,
                        principalTable: "TB_SKATE",
                        principalColumn: "SkateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaSkate_SkatesSkateId",
                table: "CategoriaSkate",
                column: "SkatesSkateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriaSkate");
        }
    }
}
