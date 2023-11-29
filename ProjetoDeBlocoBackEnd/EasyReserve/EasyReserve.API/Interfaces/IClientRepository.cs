using EasyReserve.API.Models;

namespace EasyReserve.API.Interfaces;

public interface IClientRepository
{
    void CreateClient(Client client);
    void UpdateClient(Client client);
    void DeleteClient(Client client);
    
    Task<Client> GetByClientId(int id);
    Task<IEnumerable<Client>> GetAllClients();
    Task<bool> SaveAllAsync();
}