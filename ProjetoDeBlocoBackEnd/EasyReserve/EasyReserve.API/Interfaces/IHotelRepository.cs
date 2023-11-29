using EasyReserve.API.Models;

namespace EasyReserve.API.Interfaces;

public interface IHotelRepository
{
    Task<Hotel> CreateHotel(Hotel hotel);
    Task<Hotel> UpdateHotel(Hotel hotel);
    Task<Hotel> DeleteHotel(int id);
    
    Task<Hotel> GetByHotelId(int id);
    Task<IEnumerable<Hotel>> GetAllHotels();
    // Task<bool> SaveAllAsync();
}