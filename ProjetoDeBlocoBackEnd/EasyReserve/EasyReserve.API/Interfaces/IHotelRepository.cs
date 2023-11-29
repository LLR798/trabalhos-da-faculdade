using EasyReserve.API.Models;

namespace EasyReserve.API.Interfaces;

public interface IHotelRepository
{
    void CreateHotel(Hotel hotel);
    void UpdateHotel(Hotel hotel);
    void DeleteHotel(Hotel hotel);
    
    Task<Hotel> GetByHotelId(int id);
    Task<IEnumerable<Hotel>> GetAllHotels();
    Task<bool> SaveAllAsync();
}