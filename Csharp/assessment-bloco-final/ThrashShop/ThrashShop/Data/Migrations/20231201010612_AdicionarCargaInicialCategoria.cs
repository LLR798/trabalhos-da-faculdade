using Microsoft.EntityFrameworkCore.Migrations;
using ThrashShop.Models;

#nullable disable

namespace ThrashShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarCargaInicialCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new AppDbContext();
            context.Categorias.AddRange(ObterCargaInicial());
            context.SaveChanges();
        }

        private IList<Categoria> ObterCargaInicial()
        {
            return new List<Categoria>()
            {
                new Categoria() {Descricao = "Rolamento" },
                new Categoria() {Descricao = "Shape" },
                new Categoria() {Descricao = "Parafusos" },
                new Categoria() {Descricao = "Trucks" },
                new Categoria() {Descricao = "Lixas" },
                new Categoria() {Descricao = "Acessórios" },
                new Categoria() {Descricao = "Rodas" },
            };
        }
    }
}
