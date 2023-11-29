using AutoMapper;
using EasyReserve.API.DTOs;
using EasyReserve.API.Interfaces;
using EasyReserve.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace EasyReserve.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HotelController : Controller
{
    private readonly IHotelRepository _hotelRepository;
    private readonly IMapper _mapper;
    public HotelController(IHotelRepository hotelRepository, IMapper mapper)
    {
        _hotelRepository = hotelRepository;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<ActionResult> CreateHotel(HotelDTO hotelDTO)
    {
        var hotel = _mapper.Map<Hotel>(hotelDTO);
        
        _hotelRepository.CreateHotel(hotel);

        if (await _hotelRepository.SaveAllAsync())
        {
            return Ok("Hotel cadastrado com sucesso.");
        }
        
        return BadRequest("Ocorreu um erro ao tentar cadastrar o hotel.");
    }
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Hotel>>> GetAllHotels()
    {
        var hotels = await _hotelRepository.GetAllHotels();
        var hotelsDTO = _mapper.Map<IEnumerable<HotelDTO>>(hotels);
        return Ok(hotelsDTO);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetHotel(int id)
    {
        var hotel = await _hotelRepository.GetByHotelId(id);

        if (hotel == null)
        {
            return NotFound("Hotel não encontrado, verifique o Id do hotel.");
        }

        var hotelDTO = _mapper.Map<HotelDTO>(hotel);

        return Ok(hotelDTO);
    }

    [HttpPut]
    public async Task<ActionResult> UpdateHotel(HotelDTO hotelDTO)
    {
        var hotel = _mapper.Map<Hotel>(hotelDTO);
        
        _hotelRepository.UpdateHotel(hotel);

        if (await _hotelRepository.SaveAllAsync())
        {
            return Ok("Hotel alterado com sucesso.");
        }

        return BadRequest("Ocorreu um erro ao tentar alterar os dados do hotel.");
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteHotel(int id)
    {
        var hotel = await _hotelRepository.GetByHotelId(id);

        if (hotel == null)
        {
            return NotFound("Hotel não encontrado, verifique o Id do hotel.");
        }
        
        _hotelRepository.DeleteHotel(hotel);

        if (await _hotelRepository.SaveAllAsync())
        {
            return Ok("Hotel excluído com sucesso.");
        }

        return BadRequest("Ocorreu um erro ao tentar excluir o hotel.");
    }
}