using System.ComponentModel.DataAnnotations;

namespace ThrashShop.Models;

public class Marca
{

    public int MarcaId { get; set; }
    
    [Display(Name = "Marca")]
    public string Nome { get; set; }
    
    public ICollection<Skate> Skates { get; set; }
}