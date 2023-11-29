using AutoMapper;
using EasyReserve.API.DTOs;
using EasyReserve.API.Interfaces;
using EasyReserve.API.Models;

namespace EasyReserve.API.Services.ClientService;

public class ClientService : IClientService
{
    private readonly IClientRepository _clientRepository;
    private readonly IMapper _mapper;

    public ClientService(IClientRepository clientRepository, IMapper mapper)
    {
        _clientRepository = clientRepository;
        _mapper = mapper;
    }

    public async Task<ClientDTO> CreateClient(ClientDTO clientDTO)
    {
        var client = _mapper.Map<Client>(clientDTO);
        var clientAdded = await _clientRepository.CreateClient(client);
        
        return _mapper.Map<ClientDTO>(clientAdded);
    }

    public async Task<ClientDTO> UpdateClient(ClientDTO clientDTO)
    {
        var client = _mapper.Map<Client>(clientDTO);
        var clientUpdated = await _clientRepository.UpdateClient(client);
        
        return _mapper.Map<ClientDTO>(clientUpdated);
    }

    public async Task<ClientDTO> DeleteClient(int id)
    {
        var clientDeleted = await _clientRepository.GetByClientId(id);
        return _mapper.Map<ClientDTO>(clientDeleted);
    }

    public async Task<ClientDTO> GetByClientId(int id)
    {
        var client = await _clientRepository.GetByClientId(id);
        return _mapper.Map<ClientDTO>(client);
    }

    public async Task<IEnumerable<ClientDTO>> GetAllClients()
    {
        var clients = await _clientRepository.GetAllClients();
        return _mapper.Map<IEnumerable<ClientDTO>>(clients);
    }
}