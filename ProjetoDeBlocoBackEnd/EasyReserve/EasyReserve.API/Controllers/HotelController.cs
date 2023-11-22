using EasyReserve.API.Models;
using EasyReserve.API.Services.HotelService;
using Microsoft.AspNetCore.Mvc;

namespace EasyReserve.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HotelController : Controller
{
    private readonly IHotelService _hotelService;

    public HotelController(IHotelService hotelService)
    {
        _hotelService = hotelService;
    }

    [HttpPost]
    public async Task<ActionResult> CreateHotel(Hotel hotel)
    {
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
        return Ok(await _hotelService.GetAllHotels());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetById(int id)
    {
        var hotel = await _hotelService.GetById(id);

        if (hotel == null)
        {
            return NotFound("Hotel não encontrado, verifique o id do hotel.");
        }
        
        return Ok(hotel);
    }

    [HttpPut]
    public async Task<ActionResult> UpdateHotel(Hotel hotel)
    {
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