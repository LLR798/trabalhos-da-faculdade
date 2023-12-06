using EasyReserve.API.DTOs;
using EasyReserve.API.Services.ClientService;
using Microsoft.AspNetCore.Mvc;

namespace EasyReserve.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientController : ControllerBase
{
    private readonly IClientService _clientService;

    public ClientController(IClientService clientService)
    {
        _clientService = clientService;
    }

    [HttpPost]
    public async Task<ActionResult> CreateClient(ClientDTO clientDTO)
    {
        var clientDTOAdded = await _clientService.CreateClient(clientDTO);

        if (clientDTOAdded == null)
        {
            return BadRequest("Ocorreu um erro ao tentar cadastrar o cliente.");
        }
        
        return Ok("Cliente cadastrado com sucesso.");
    }

    [HttpGet]
    public async Task<ActionResult> GetAllClient()
    {
        var clientsDTO = await _clientService.GetAllClients();
        return Ok(clientsDTO);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetClient(int id)
    {
        var clientDTO = await _clientService.GetByClientId(id);

        if (clientDTO == null)
        {
            return NotFound("Cliente não encontrado, verifique o Id do cliente.");
        }

        return Ok(clientDTO);
    }

    [HttpPut]
    public async Task<ActionResult> UpdateClient(ClientDTO clientDTO)
    {
        if (clientDTO.ClientId == 0)
        {
            return BadRequest("Id inválido. Não é possível atualizar um cliente sem um Id válido.");
        }
        
        var existingClient = await _clientService.GetByClientId(clientDTO.ClientId);

        if (existingClient == null)
        {
            return NotFound("Cliente não encontrado. Verifique o Id do cliente.");
        }

        var clientDTOUpdated = await _clientService.UpdateClient(clientDTO);

        if (clientDTOUpdated == null)
        {
            return BadRequest("Ocorreu um erro ao tentar alterar os dados do cliente.");
        }
        
        return Ok("Cliente alterado com sucesso.");
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteClient(int id)
    {
        var client = await _clientService.GetByClientId(id);

        if (client == null)
        {
            return NotFound("Cliente não encontrado, verifique o Id do cliente.");
        }
        
        var clientDTODeleted = await _clientService.DeleteClient(id);

        if (clientDTODeleted == null)
        {
            return BadRequest("Ocorreu um erro ao tentar excluir o cliente.");
        }
        
        return Ok("Cliente excluido com sucesso.");
    }
}