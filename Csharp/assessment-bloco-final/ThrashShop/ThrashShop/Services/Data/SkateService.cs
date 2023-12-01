using Microsoft.EntityFrameworkCore;
using ThrashShop.Data;
using ThrashShop.Models;

namespace ThrashShop.Services.Data;

public class SkateService : ISkateService
{
    private readonly AppDbContext _context;
    public SkateService(AppDbContext context)
    {
        _context = context;
    }
    public IList<Skate> ObterTodos()
    {
        return _context.Skates.ToList();
    }

    public Skate Obter(int id)
    {
        return _context.Skates
            .Include(item => item.Categorias)
            .SingleOrDefault(item => item.SkateId == id);
    }
    
    public IList<Marca> ObterTodasAsMarcas()
    {
        return _context.Marcas.ToList();
    } 
    
    public IList<Categoria> ObterTodasAsCategorias()
    {
        return _context.Categorias.ToList();
    }

    public void Incluir(Skate skate)
    {
        _context.Skates.Add(skate);
        _context.SaveChanges();
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
        skateEncontrado.MarcaId = skate.MarcaId;
        skateEncontrado.Categorias = skate.Categorias;

        _context.SaveChanges();
    }

    public void Excluir(int id)
    {
        var skateEncontrado = Obter(id);
        _context.Skates.Remove(skateEncontrado);
        _context.SaveChanges();
    }
}