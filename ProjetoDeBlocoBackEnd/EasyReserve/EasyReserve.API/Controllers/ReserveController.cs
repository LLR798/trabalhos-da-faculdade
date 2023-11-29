using EasyReserve.API.DTOs;
using EasyReserve.API.Services.ReserveService;
using Microsoft.AspNetCore.Mvc;

namespace EasyReserve.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReserveController : Controller
{
    private readonly IReserveService _reserveService;

    public ReserveController(IReserveService reserveService)
    {
        _reserveService = reserveService;
    }

    [HttpPost]
    public async Task<ActionResult> CreateReserve(ReserveDTO reserveDTO)
    {
        var reserveDTOAdded = await _reserveService.CreateReserve(reserveDTO);

        if (reserveDTOAdded == null)
        {
            return BadRequest("Ocorreu um erro ao tentar cadastrar o reserva.");
        }
        
        return Ok("Reserva cadastrada com sucesso.");
    }

    [HttpGet]
    public async Task<ActionResult> GetAllReservetions()
    {
        var reservationsDTO = await _reserveService.GetAllReservations();
        return Ok(reservationsDTO);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetReserve(int id)
    {
        var reserveDTO = await _reserveService.GetByReserveId(id);

        if (reserveDTO == null)
        {
            return NotFound("Reserva não encontrada, verifique o Id da reserva.");
        }
        
        return Ok(reserveDTO); 
    }

    [HttpPut]
    public async Task<ActionResult> UpdateReserve(ReserveDTO reserveDTO)
    {
        if (reserveDTO.ReserveId == 0)
        {
            return BadRequest("Id inválido. Não é possível atualizar uma reserva sem um Id válido.");
        }
    
        var existingReserve = await _reserveService.GetByReserveId(reserveDTO.ReserveId);
    
        if (existingReserve == null)
        {
            return NotFound("Reserva não encontrado. Verifique o Id da reserva.");
        }
    
        var reserveDTOUpdated = await _reserveService.UpdateReserve(reserveDTO);
    
        if (reserveDTOUpdated == null)
        {
            return BadRequest("Ocorreu um erro ao tentar alterar os dados do reserva.");
        }
    
        return Ok("Reserva alterada com sucesso.");
    }


    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteReserve(int id)
    {
        var reserve = await _reserveService.GetByReserveId(id);

        if (reserve == null)
        {
            return NotFound("Reserva não encontrada, verifique o Id do reserva.");
        }

        var reserveDTODeleted = await _reserveService.DeleteReserve(id);

        if (reserveDTODeleted == null)
        {
            return BadRequest("Ocorreu um erro ao tentar excluir o reserva.");
        }

        return Ok("Reserva excluída com sucesso."); 
    }
}