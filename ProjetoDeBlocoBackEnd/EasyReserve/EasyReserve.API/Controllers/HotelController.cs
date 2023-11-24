using AutoMapper;
using EasyReserve.API.DTOs;
using EasyReserve.API.Models;
using EasyReserve.API.Services.HotelService;
using Microsoft.AspNetCore.Mvc;

namespace EasyReserve.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HotelController : Controller
{
    private readonly IHotelService _hotelService;
    private readonly IMapper _mapper;

    public HotelController(IHotelService hotelService, IMapper mapper)
    {
        _hotelService = hotelService;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<ActionResult> CreateHotel(HotelDTO hotelDTO)
    {
        var hotel = _mapper.Map<Hotel>(hotelDTO);
        
        _hotelService.Create(hotel);
        if (await _hotelService.SaveAllAsync())
        {
            return Ok("Hotel cadastrado com sucesso.");
        }

        return BadRequest("Erro ao tentar criar um novo hotel.");
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Hotel>>> GetAllHotels()
    {
        var hotels = await _hotelService.GetAllHotels();
        var hotelsDTO = _mapper.Map<IEnumerable<HotelDTO>>(hotels);
        
        return Ok(hotelsDTO);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetById(int id)
    {
        var hotel = await _hotelService.GetById(id);

        if (hotel == null)
        {
            return NotFound("Hotel não encontrado, verifique o id do hotel.");
        }

        var hotelDTO = _mapper.Map<HotelDTO>(hotel);
        
        return Ok(hotelDTO);
    }

    [HttpPut]
    public async Task<ActionResult> UpdateHotel(HotelDTO hotelDTO)
    {
        if (hotelDTO.HotelId == 0)
        {
            return BadRequest("Erro ao tentar alterar o hotel. É preciso informar o ID.");
        }

        var hotelExist = await _hotelService.GetById(hotelDTO.HotelId);
        if (hotelExist == null)
        {
            return NotFound("Hotel não encontrado, verifique se o ID está correto.");
        }
        
        var hotel = _mapper.Map<Hotel>(hotelDTO);
        
        _hotelService.Update(hotel);
        if (await _hotelService.SaveAllAsync())
        {
            return Ok("Hotel alterado com sucesso!");
        }

        return BadRequest("Ocorreu um erro ao tentar fazer a alteração.");
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteHotel(int id)
    {
        var hotel = await _hotelService.GetById(id);

        if (hotel == null)
        {
            return NotFound("Hotel não encontrado, verifique se o id está correto.");
        }
        
        _hotelService.Delete(hotel);
        
        if (await _hotelService.SaveAllAsync())
        {
            return Ok("Hotel excluído com sucesso!");
        }

        return BadRequest("Erro ao tentar excluir o hotel.");
    }
}