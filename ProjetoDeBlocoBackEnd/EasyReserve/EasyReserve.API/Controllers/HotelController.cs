using EasyReserve.API.Interfaces;
using EasyReserve.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace EasyReserve.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HotelController : Controller
{
    private readonly IHotelRepository _hotelRepository;

    public HotelController(IHotelRepository hotelRepository)
    {
        _hotelRepository = hotelRepository;
    }

    [HttpPost]
    public async Task<ActionResult> CreateHotel(Hotel hotel)
    {
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
        return Ok(await _hotelRepository.GetAllHotels());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetHotel(int id)
    {
        var hotel = await _hotelRepository.GetByHotelId(id);

        if (hotel == null)
        {
            return NotFound("Hotel não encontrado, verifique o Id do hotel.");
        }

        return Ok(hotel);
    }

    [HttpPut]
    public async Task<ActionResult> UpdateHotel(Hotel hotel)
    {
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