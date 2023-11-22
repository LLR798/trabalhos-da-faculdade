using Microsoft.EntityFrameworkCore.Migrations;
using ThrashShop.Models;

#nullable disable

namespace ThrashShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarCargaInicialmarca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new AppDbContext();
            context.Marcas.AddRange(ObterCargaInicial());
            context.SaveChanges();
        }

        private IList<Marca> ObterCargaInicial()
        {
            return new List<Marca>()
            {
                new Marca() {Nome = "Girl" },
                new Marca() {Nome = "Baker" },
                new Marca() {Nome = "Element" },
                new Marca() {Nome = "Plan B" },
                new Marca() {Nome = "Primitive" },
                new Marca() {Nome = "Santa Cruz" },
                new Marca() {Nome = "DGK" },
                new Marca() {Nome = "Krooked" },
                new Marca() {Nome = "Zero" },
                new Marca() {Nome = "April" },
            };
        }
    }
}
