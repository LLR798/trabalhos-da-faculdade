using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyReserve.API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFieldIdReserve : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReservaId",
                table: "Reserves",
                newName: "ReserveId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReserveId",
                table: "Reserves",
                newName: "ReservaId");
        }
    }
}
