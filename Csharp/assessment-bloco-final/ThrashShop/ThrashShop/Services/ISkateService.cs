using ThrashShop.Models;

namespace ThrashShop.Services;

public interface ISkateService
{
    IList<Skate> ObterTodos();
    Skate Obter(int id);
    void Incluir(Skate skate);
    void Alterar(Skate skate);
    void Excluir(int id);
}