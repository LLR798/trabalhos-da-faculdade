using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThrashShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarRelacionamentoSkateMarca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MarcaId",
                table: "TB_SKATE",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_SKATE_MarcaId",
                table: "TB_SKATE",
                column: "MarcaId");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_SKATE_Marcas_MarcaId",
                table: "TB_SKATE",
                column: "MarcaId",
                principalTable: "Marcas",
                principalColumn: "MarcaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_SKATE_Marcas_MarcaId",
                table: "TB_SKATE");

            migrationBuilder.DropIndex(
                name: "IX_TB_SKATE_MarcaId",
                table: "TB_SKATE");

            migrationBuilder.DropColumn(
                name: "MarcaId",
                table: "TB_SKATE");
        }
    }
}
