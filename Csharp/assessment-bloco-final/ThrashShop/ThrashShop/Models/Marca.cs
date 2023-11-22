using System.ComponentModel.DataAnnotations;

namespace ThrashShop.Models;

public class Marca
{
    [Display(Name = "Marca")]
    public int MarcaId { get; set; }
    public string Nome { get; set; }
    
    public ICollection<Skate> Skates { get; set; }
}