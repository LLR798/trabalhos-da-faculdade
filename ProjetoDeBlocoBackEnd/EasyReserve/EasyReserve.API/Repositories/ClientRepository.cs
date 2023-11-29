using EasyReserve.API.Data;
using EasyReserve.API.Interfaces;
using EasyReserve.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyReserve.API.Repositories;

public class ClientRepository : IClientRepository
{
    private readonly AppDbContext _context;

    public ClientRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Client> CreateClient(Client client)
    {
        _context.Clients.Add(client);
        await _context.SaveChangesAsync();
        return client;
    }

    public async Task<Client> UpdateClient(Client client)
    {
        var existingClient = await _context.Clients.FindAsync(client.ClientId);

        if (existingClient != null)
        {
            _context.Entry(existingClient).State = EntityState.Detached;
        }

        _context.Clients.Update(client);
        await _context.SaveChangesAsync();
        return client;
    }

    public async Task<Client> DeleteClient(int id)
    {
        var client = await _context.Clients.FindAsync(id);

        if (client != null)
        {
            _context.Clients.Remove(client);
            await _context.SaveChangesAsync();
        }
        
        return client;
    }

    public async Task<Client> GetByClientId(int id)
    {
        return await _context.Clients.Where(x => x.ClientId == id).FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<Client>> GetAllClients()
    {
        return await _context.Clients.ToListAsync();
    }
}