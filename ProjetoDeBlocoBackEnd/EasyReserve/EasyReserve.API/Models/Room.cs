using System.ComponentModel.DataAnnotations;

namespace EasyReserve.API.Models;

public class Room
{
    [Key]
    public int RoomId { get; set; }
    
    public int? HotelId { get; set; }
    
    [Required]
    [StringLength(20, ErrorMessage = "O número do quarto não pode ter mais de 20 caracteres.")]
    public string Number { get; set; }
    
    [Required]
    [MaxLength(50, ErrorMessage = "O tipo não pode ter mais de 50 caracteres.")]
    public string Type { get; set; }
    
    [Required]
    [MaxLength(5000, ErrorMessage = "A descrição não pode ter mais de 5.000 caracteres.")]
    public string Description { get; set; }
    
    [Required]
    public bool IsReserved { get; set; }
    
    [Required]
    public decimal Price { get; set; }
    
    public Hotel Hotel { get; set; }
    
    public ICollection<Reserve> Reserves { get; set; } = new List<Reserve>();

}