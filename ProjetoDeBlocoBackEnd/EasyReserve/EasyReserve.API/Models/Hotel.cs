using System.ComponentModel.DataAnnotations;

namespace EasyReserve.API.Models;

public class Hotel
{
    [Key]
    public int HotelId { get; set; }
    
    [Required]
    [MaxLength(255, ErrorMessage = "O nome do hotel não pode ter mais de 255 caracteres.")]
    public string Name { get; set; }
    
    [Required]
    [MaxLength(400, ErrorMessage = "O endereço do hotel não pode ter mais de 400 caracteres.")]
    public string Address { get; set; }
    
    [Required]
    [MaxLength(50, ErrorMessage = "A categoria não pode ter mais de 50 caracteres.")]
    public string Category { get; set; }
    
    [Required]
    [MaxLength(5000, ErrorMessage = "A descrição não pode ter mais de 5.000 caracteres.")]
    public string Description { get; set; }

    public ICollection<Room> Rooms { get; set; } = new List<Room>();
}