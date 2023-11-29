using EasyReserve.API.Data;
using EasyReserve.API.Interfaces;
using EasyReserve.API.Models;

namespace EasyReserve.API.Repositories;

public class ClientRepository : IClientRepository
{
    private readonly AppDbContext _context;

    public ClientRepository(AppDbContext context)
    {
        _context = context;
    }

    public void CreateClient(Client client)
    {
        throw new NotImplementedException();
    }

    public void UpdateClient(Client client)
    {
        throw new NotImplementedException();
    }

    public void DeleteClient(Client client)
    {
        throw new NotImplementedException();
    }

    public Task<Client> GetByClientId(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Client>> GetAllClients()
    {
        throw new NotImplementedException();
    }

    public async Task<bool> SaveAllAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }
}