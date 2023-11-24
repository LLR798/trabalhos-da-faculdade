namespace EasyReserve.API.DTOs;

public class HotelDTO
{
    public int HotelId { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Description { get; set; } = null!;
}