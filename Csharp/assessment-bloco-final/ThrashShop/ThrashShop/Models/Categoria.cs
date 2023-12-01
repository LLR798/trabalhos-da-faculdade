namespace ThrashShop.Models;

public class Categoria
{
    public int CategoriaId { get; set; }
    public string Descricao { get; set; }
    
    public ICollection<Skate>? Skates { get; set; }
}