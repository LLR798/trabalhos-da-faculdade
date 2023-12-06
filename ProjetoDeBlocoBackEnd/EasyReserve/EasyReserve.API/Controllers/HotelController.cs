using AutoMapper;
using EasyReserve.API.DTOs;
using EasyReserve.API.Interfaces;
using EasyReserve.API.Models;
using EasyReserve.API.Services.HotelService;
using Microsoft.AspNetCore.Mvc;

namespace EasyReserve.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HotelController : ControllerBase
{
    private readonly IHotelService _hotelService;
    public HotelController(IHotelService hotelService)
    {
        _hotelService = hotelService;
    }

    [HttpPost]
    public async Task<ActionResult> CreateHotel(HotelDTO hotelDTO)
    {
        var hotelDTOAdded = await _hotelService.CreateHotel(hotelDTO);

        if (hotelDTOAdded == null)
        {
            return BadRequest("Ocorreu um erro ao tentar cadastrar o hotel.");
        }
        
        return Ok("Hotel cadastrado com sucesso.");
    }
    
    [HttpGet]
    public async Task<ActionResult> GetAllHotels()
    {
        var hotelsDTO = await _hotelService.GetAllHotels();
        return Ok(hotelsDTO);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetHotel(int id)
    {
        var hotelDTO = await _hotelService.GetByHotelId(id);

        if (hotelDTO == null)
        {
            return NotFound("Hotel não encontrado, verifique o Id do hotel.");
        }
        
        return Ok(hotelDTO);
    }
    
    [HttpPut]
    public async Task<ActionResult> UpdateHotel(HotelDTO hotelDTO)
    {
        if (hotelDTO.HotelId == 0)
        {
            return BadRequest("Id inválido. Não é possível atualizar um hotel sem um Id válido.");
        }
    
        var existingHotel = await _hotelService.GetByHotelId(hotelDTO.HotelId);
    
        if (existingHotel == null)
        {
            return NotFound("Hotel não encontrado. Verifique o Id do hotel.");
        }
    
        var hotelDTOUpdated = await _hotelService.UpdateHotel(hotelDTO);
    
        if (hotelDTOUpdated == null)
        {
            return BadRequest("Ocorreu um erro ao tentar alterar os dados do hotel.");
        }
    
        return Ok("Hotel alterado com sucesso.");
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteHotel(int id)
    {
        var hotel = await _hotelService.GetByHotelId(id);

        if (hotel == null)
        {
            return NotFound("Hotel não encontrado, verifique o Id do hotel.");
        }

        var hotelDTODeleted = await _hotelService.DeleteHotel(id);

        if (hotelDTODeleted == null)
        {
            return BadRequest("Ocorreu um erro ao tentar excluir o hotel.");
        }

        return Ok("Hotel excluído com sucesso.");
    }
}