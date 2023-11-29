using System.ComponentModel.DataAnnotations;

namespace EasyReserve.API.Models;

public class Reserve
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
    
    public Client? Client { get; set; }
    
    public Room? Room { get; set; }
}