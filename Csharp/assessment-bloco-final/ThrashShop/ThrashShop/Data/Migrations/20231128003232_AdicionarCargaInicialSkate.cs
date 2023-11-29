using Microsoft.EntityFrameworkCore.Migrations;
using ThrashShop.Models;

#nullable disable

namespace ThrashShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarCargaInicialSkate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new AppDbContext();
            context.Skates.AddRange(ObterCargaInicial());
            context.SaveChanges();
        }
        
        private IList<Skate> ObterCargaInicial()
        {
            return new List<Skate>()
            {
                // Ver se já vai estar commitado no git
                // Pegar a carga inicial dos hamburguers 
                // E commitar
                // Depois tentar fazer o delete e ver se consegue recriar o banco
                new Skate
                {
                    Nome = "Rolamento Reds Bones",
                    Descricao = "Rolamento Bones Big Balls de alta precisão.",
                    ImagemUri = "/images/bearings1.png",
                    DataCadastro = DateTime.Now,
                    EntregaExpressa = true,
                    Preco = 399.00,
                },
                new Skate
                {
                    Nome = "Rolamento Atoms Quantum",
                    Descricao = "Rolamento Atoms de cerâmica.",
                    ImagemUri = "/images/bearings2.png",
                    DataCadastro = DateTime.Now,
                    EntregaExpressa = true,
                    Preco = 600.00,
                },
                new Skate
                {
                    Nome = "Shape Maple Baker",
                    Descricao = "Shape de Maple 8.25, da Baker.",
                    ImagemUri = "/images/deck1.png",
                    DataCadastro = DateTime.Now,
                    EntregaExpressa = true,
                    Preco = 399.00,
                },
                new Skate
                {
                    Nome = "Shape Maple Girl",
                    Descricao = "Shape de maple 8.0, da Girl Multiverse.",
                    ImagemUri = "/images/deck2.png",
                    DataCadastro = DateTime.Now,
                    EntregaExpressa = false,
                    Preco = 650.00,
                },
                new Skate
                {
                    Nome = "Lixa emborrachada DGK",
                    Descricao = "Lixa emborrachada DGK, com ótimo grip.",
                    ImagemUri = "/images/grip1.png",
                    DataCadastro = DateTime.Now,
                    EntregaExpressa = true,
                    Preco = 120.00,
                },
                new Skate
                {
                    Nome = "Lixa emborrachada Jessup",
                    Descricao = "Lixa emborrachada Jessup, com grip muito bom.",
                    ImagemUri = "/images/grip2.png",
                    DataCadastro = DateTime.Now,
                    EntregaExpressa = true,
                    Preco = 49.00,
                },
                new Skate
                {
                    Nome = "Parafusos Independent",
                    Descricao = "Parafusos Independent Vermelho de 1 polegada.",
                    ImagemUri = "/images/hardware1.png",
                    DataCadastro = DateTime.Now,
                    EntregaExpressa = true,
                    Preco = 20.00,
                },
                new Skate
                {
                    Nome = "Parafusos Independent",
                    Descricao = "Parafusos Independent Preto de 1 polegada.",
                    ImagemUri = "/images/hardware2.png",
                    DataCadastro = DateTime.Now,
                    EntregaExpressa = true,
                    Preco = 20.00,
                },
                new Skate
                {
                    Nome = "Truck Silver",
                    Descricao = "Truck Silver de 144mm preto.",
                    ImagemUri = "/images/truck1.png",
                    DataCadastro = DateTime.Now,
                    EntregaExpressa = true,
                    Preco = 299.00,
                },
                new Skate
                {
                    Nome = "Truck Independent",
                    Descricao = "Truck Independent de 149mm Prata.",
                    ImagemUri = "/images/truck2.png",
                    DataCadastro = DateTime.Now,
                    EntregaExpressa = true,
                    Preco = 549.00,
                },
                new Skate
                {
                    Nome = "Roda Spitfire",
                    Descricao = "Roda Spitfire Formula-four de 54mm dureza 98A. O kit contém 4 unidades.",
                    ImagemUri = "/images/wheels1.png",
                    DataCadastro = DateTime.Now,
                    EntregaExpressa = true,
                    Preco = 230.00,
                },
                new Skate
                {
                    Nome = "Roda Bones",
                    Descricao = "Roda Bones de 52mm dureza 100A. O kit contém 4 unidades.",
                    ImagemUri = "/images/wheels2.png",
                    DataCadastro = DateTime.Now,
                    EntregaExpressa = true,
                    Preco = 300.00,
                },
            };
        }
        
    }
}
