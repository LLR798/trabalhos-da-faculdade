using System.ComponentModel.DataAnnotations;

namespace EasyReserve.API.DTOs;

public class ReserveDTO
{
    [Key]
    public int ReserveId { get; set; }
    
    [Required]
    public int RoomId { get; set; }
    
    [Required]
    public int ClientId { get; set; }
    
    [Required]
    public DateTime DataCheckIn { get; set; }
    
    [Required]
    public DateTime DataCheckOut { get; set; }
    
    [Required]
    public decimal TotalCost { get; set; }
}