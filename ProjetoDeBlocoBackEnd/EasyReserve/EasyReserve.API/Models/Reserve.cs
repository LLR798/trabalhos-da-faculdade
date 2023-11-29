using System.ComponentModel.DataAnnotations;

namespace EasyReserve.API.Models;

public class Reserve
{
    [Key]
    [Required]
    public int ReservaId { get; set; }
    
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
    
    [Required]
    public Client Client { get; set; }
    
    [Required]
    public Room Room { get; set; }
}