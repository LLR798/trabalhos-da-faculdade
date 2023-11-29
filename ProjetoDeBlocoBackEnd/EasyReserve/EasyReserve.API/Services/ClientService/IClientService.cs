using EasyReserve.API.DTOs;

namespace EasyReserve.API.Services.ClientService;

public interface IClientService
{
    Task<ClientDTO> CreateClient(ClientDTO clientDTO);
    Task<ClientDTO> UpdateClient(ClientDTO clientDTO);
    Task<ClientDTO> DeleteClient(int id);
    
    Task<ClientDTO> GetByClientId(int id);
    Task<IEnumerable<ClientDTO>> GetAllClients();
}