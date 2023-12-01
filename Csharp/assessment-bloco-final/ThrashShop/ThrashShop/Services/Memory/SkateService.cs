using ThrashShop.Models;

namespace ThrashShop.Services.Memory;

public class SkateService : ISkateService
{
    private IList<Skate> _skates;

    public SkateService() 
        => CarregarListaInicial();

    private void CarregarListaInicial()
    {
        _skates = new List<Skate>() {
            new Skate
            {
                SkateId = 1,
                Nome = "Rolamento Reds Bones",
                Descricao = "Rolamento Bones Big Balls de alta precisão.",
                ImagemUri = "/images/bearings1.png",
                DataCadastro = DateTime.Now,
                EntregaExpressa = true,
                Preco = 399.00,
            },
            new Skate
            {
                SkateId = 2,
                Nome = "Rolamento Atoms Quantum",
                Descricao = "Rolamento Atoms de cerâmica.",
                ImagemUri = "/images/bearings2.png",
                DataCadastro = DateTime.Now,
                EntregaExpressa = true,
                Preco = 600.00,
            },
            new Skate
            {
                SkateId = 3,
                Nome = "Shape Maple Baker",
                Descricao = "Shape de Maple 8.25, da Baker.",
                ImagemUri = "/images/deck1.png",
                DataCadastro = DateTime.Now,
                EntregaExpressa = true,
                Preco = 399.00,
            },
            new Skate
            {
                SkateId = 4,
                Nome = "Shape Maple Girl",
                Descricao = "Shape de maple 8.0, da Girl Multiverse.",
                ImagemUri = "/images/deck2.png",
                DataCadastro = DateTime.Now,
                EntregaExpressa = false,
                Preco = 650.00,
            },
            new Skate
            {
                SkateId = 5,
                Nome = "Lixa emborrachada DGK",
                Descricao = "Lixa emborrachada DGK, com ótimo grip.",
                ImagemUri = "/images/grip1.png",
                DataCadastro = DateTime.Now,
                EntregaExpressa = true,
                Preco = 120.00,
            },
            new Skate
            {
                SkateId = 6,
                Nome = "Lixa emborrachada Jessup",
                Descricao = "Lixa emborrachada Jessup, com grip muito bom.",
                ImagemUri = "/images/grip2.png",
                DataCadastro = DateTime.Now,
                EntregaExpressa = true,
                Preco = 49.00,
            },
            new Skate
            {
                SkateId = 7,
                Nome = "Parafusos Independent",
                Descricao = "Parafusos Independent Vermelho de 1 polegada.",
                ImagemUri = "/images/hardware1.png",
                DataCadastro = DateTime.Now,
                EntregaExpressa = true,
                Preco = 20.00,
            },
            new Skate
            {
                SkateId = 8,
                Nome = "Parafusos Independent",
                Descricao = "Parafusos Independent Preto de 1 polegada.",
                ImagemUri = "/images/hardware2.png",
                DataCadastro = DateTime.Now,
                EntregaExpressa = true,
                Preco = 20.00,
            },
            new Skate
            {
                SkateId = 9,
                Nome = "Truck Silver",
                Descricao = "Truck Silver de 144mm preto.",
                ImagemUri = "/images/truck1.png",
                DataCadastro = DateTime.Now,
                EntregaExpressa = true,
                Preco = 299.00,
            },
            new Skate
            {
                SkateId = 10,
                Nome = "Truck Independent",
                Descricao = "Truck Independent de 149mm Prata.",
                ImagemUri = "/images/truck2.png",
                DataCadastro = DateTime.Now,
                EntregaExpressa = true,
                Preco = 549.00,
            },
            new Skate
            {
                SkateId = 11,
                Nome = "Roda Spitfire",
                Descricao = "Roda Spitfire Formula-four de 54mm dureza 98A. O kit contém 4 unidades.",
                ImagemUri = "/images/wheels1.png",
                DataCadastro = DateTime.Now,
                EntregaExpressa = true,
                Preco = 230.00,
            },
            new Skate
            {
                SkateId = 12,
                Nome = "Roda Bones",
                Descricao = "Roda Bones de 52mm dureza 100A. O kit contém 4 unidades.",
                ImagemUri = "/images/wheels2.png",
                DataCadastro = DateTime.Now,
                EntregaExpressa = true,
                Preco = 300.00,
            },
        };
    }

    public IList<Skate> ObterTodos()
        => _skates;

    public Skate Obter(int id)
    {
        return _skates.SingleOrDefault(item => item.SkateId == id);
    }

    public void Incluir(Skate hamburguer)
    {
        var proximoNumero = _skates.Max(item =>  item.SkateId) + 1;
        hamburguer.SkateId = proximoNumero;
        _skates.Add(hamburguer);
    }

    public void Alterar(Skate skate)
    {
        var skateEncontrado = Obter(skate.SkateId);
        skateEncontrado.Nome = skate.Nome;
        skateEncontrado.Descricao = skate.Descricao;
        skateEncontrado.Preco = skate.Preco;
        skateEncontrado.EntregaExpressa = skate.EntregaExpressa;
        skateEncontrado.DataCadastro = skate.DataCadastro;
        skateEncontrado.ImagemUri = skate.ImagemUri;
    }

    public void Excluir(int id)
    {
        var skateEncontrado = Obter(id);
        _skates.Remove(skateEncontrado);
    }

    public IList<Marca> ObterTodasAsMarcas()
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

    public IList<Categoria> ObterTodasAsCategorias()
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