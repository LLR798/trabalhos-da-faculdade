using System.ComponentModel.DataAnnotations;

namespace EasyReserve.API.Models;

public class Client
{
    [Key]
    public int ClientId { get; set; }
    
    [Required]
    [MaxLength(255, ErrorMessage = "O nome não pode ter mais de 255 caracteres.")]
    public string Name { get; set; }
    
    [Required]
    [MaxLength(255, ErrorMessage = "O e-mail não pode ter mais de 255 caracteres.")]
    public string Email { get; set; }
    
    public ICollection<Reserve> Reserves { get; set; } = new List<Reserve>();
}