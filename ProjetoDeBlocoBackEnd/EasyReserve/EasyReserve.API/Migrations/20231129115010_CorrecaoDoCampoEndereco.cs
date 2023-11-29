using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyReserve.API.Migrations
{
    /// <inheritdoc />
    public partial class CorrecaoDoCampoEndereco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "Hotels",
                newName: "Address");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Hotels",
                newName: "Adress");
        }
    }
}
