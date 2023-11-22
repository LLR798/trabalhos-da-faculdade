using EasyReserve.API.Models;

namespace EasyReserve.API.Services.HotelService;

public interface IHotelService
{
    void Create(Hotel hotel);
    Task<Hotel> GetById(int id);
    Task<IEnumerable<Hotel>> GetAllHotels();
    void Update(Hotel hotel);
    void Delete(Hotel hotel);
    Task<bool> SaveAllAsync();
}