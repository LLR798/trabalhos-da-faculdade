using AutoMapper;
using EasyReserve.API.DTOs;
using EasyReserve.API.Interfaces;
using EasyReserve.API.Models;

namespace EasyReserve.API.Services.HotelService;

public class HotelService : IHotelService
{
    private readonly IHotelRepository _hotelRepository;
    private readonly IMapper _mapper;

    public HotelService(IHotelRepository hotelRepository, IMapper mapper)
    {
        _hotelRepository = hotelRepository;
        _mapper = mapper;
    }

    public async Task<HotelDTO> CreateHotel(HotelDTO hotelDTO)
    {
        var hotel = _mapper.Map<Hotel>(hotelDTO);
        var hotelAdded = await _hotelRepository.CreateHotel(hotel);

        return _mapper.Map<HotelDTO>(hotelAdded);
    }

    public async Task<HotelDTO> UpdateHotel(HotelDTO hotelDTO)
    {
        var hotel = _mapper.Map<Hotel>(hotelDTO);
        var hotelUpdated = await _hotelRepository.UpdateHotel(hotel);

        return _mapper.Map<HotelDTO>(hotelUpdated);
    }

    public async Task<HotelDTO> DeleteHotel(int id)
    {
        var hotelDeleted = await _hotelRepository.DeleteHotel(id);
        return _mapper.Map<HotelDTO>(hotelDeleted);
    }

    public async Task<HotelDTO> GetByHotelId(int id)
    {
        var hotel = await _hotelRepository.GetByHotelId(id);
        return _mapper.Map<HotelDTO>(hotel);
    }

    public async Task<IEnumerable<HotelDTO>> GetAllHotels()
    {
        var hotels = await _hotelRepository.GetAllHotels();
        return _mapper.Map<IEnumerable<HotelDTO>>(hotels);
    }
}