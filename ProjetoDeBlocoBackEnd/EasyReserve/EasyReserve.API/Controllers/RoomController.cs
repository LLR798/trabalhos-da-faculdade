using EasyReserve.API.DTOs;
using EasyReserve.API.Services.RoomService;
using Microsoft.AspNetCore.Mvc;

namespace EasyReserve.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RoomController : ControllerBase
{
    private readonly IRoomService _roomService;

    public RoomController(IRoomService roomService)
    {
        _roomService = roomService;
    }

    [HttpPost]
    public async Task<ActionResult> CreateRoom(RoomDTO roomDTO)
    {
        var roomDTOAdded = await _roomService.CreateRoom(roomDTO);

        if (roomDTOAdded == null)
        {
            return BadRequest("Ocorreu um erro ao tentar caadastrar um quarto.");
        }

        return Ok("Quarto cadastrado com sucesso.");
    }

    [HttpGet]
    public async Task<ActionResult> GetAllRooms()
    {
        var roomsDTO = await _roomService.GetAllRooms();
        return Ok(roomsDTO);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetRoom(int id)
    {
        var roomDTO = await _roomService.GetByRoomId(id);

        if (roomDTO == null)
        {
            return NotFound("Quarto não encontrado, verifique o Id do quarto.");
        }
        
        return Ok(roomDTO);
    }
    
    [HttpPut]
    public async Task<ActionResult> UpdateRoom(RoomDTO roomDTO)
    {
        if (roomDTO.RoomId == 0)
        {
            return BadRequest("Id inválido. Não é possível atualizar um quarto sem um Id válido.");
        }
    
        var existingRoom = await _roomService.GetByRoomId(roomDTO.RoomId);
    
        if (existingRoom == null)
        {
            return NotFound("Quarto não encontrado. Verifique o Id do quarto.");
        }
    
        var roomDTOUpdated = await _roomService.UpdateRoom(roomDTO);
    
        if (roomDTOUpdated == null)
        {
            return BadRequest("Ocorreu um erro ao tentar alterar os dados do quarto.");
        }
    
        return Ok("Room alterado com sucesso.");
    }
    
    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteRoom(int id)
    {
        var room = await _roomService.GetByRoomId(id);

        if (room == null)
        {
            return NotFound("Quarto não encontrado, verifique o Id do quarto.");
        }

        var roomDTODeleted = await _roomService.DeleteRoom(id);

        if (roomDTODeleted == null)
        {
            return BadRequest("Ocorreu um erro ao tentar excluir o quarto.");
        }

        return Ok("Quarto excluído com sucesso.");
    }
}