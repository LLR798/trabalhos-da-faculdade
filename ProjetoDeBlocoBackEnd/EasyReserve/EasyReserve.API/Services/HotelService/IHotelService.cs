using EasyReserve.API.DTOs;

namespace EasyReserve.API.Services.HotelService;

public interface IHotelService
{
    Task<HotelDTO> CreateHotel(HotelDTO hotelDTO);
    Task<HotelDTO> UpdateHotel(HotelDTO hotelDTO);
    Task<HotelDTO> DeleteHotel(int id);
    
    Task<HotelDTO> GetByHotelId(int id);
    Task<IEnumerable<HotelDTO>> GetAllHotels();
}