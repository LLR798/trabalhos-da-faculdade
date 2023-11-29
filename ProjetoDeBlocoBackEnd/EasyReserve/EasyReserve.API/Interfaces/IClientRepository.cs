using EasyReserve.API.Models;

namespace EasyReserve.API.Interfaces;

public interface IClientRepository
{
    Task<Client> CreateClient(Client client);
    Task<Client> UpdateClient(Client client);
    Task<Client> DeleteClient(int id);
    
    Task<Client> GetByClientId(int id);
    Task<IEnumerable<Client>> GetAllClients();
}