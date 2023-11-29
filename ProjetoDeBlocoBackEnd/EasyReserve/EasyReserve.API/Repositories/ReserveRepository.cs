using EasyReserve.API.Data;
using EasyReserve.API.Interfaces;
using EasyReserve.API.Models;

namespace EasyReserve.API.Repositories;

public class ReserveRepository : IReserveRepository
{
    private readonly AppDbContext _context;

    public ReserveRepository(AppDbContext context)
    {
        _context = context;
    }

    public Task<Reserve> CreateReserve(Reserve reserve)
    {
        throw new NotImplementedException();
    }

    public Task<Reserve> UpdateReserve(Reserve reserve)
    {
        throw new NotImplementedException();
    }

    public Task<Reserve> DeleteReserve(Reserve reserve)
    {
        throw new NotImplementedException();
    }

    public Task<Reserve> GetByReserveId(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Reserve>> GetAllReservations()
    {
        throw new NotImplementedException();
    }

    public Task<bool> SaveAllAsync()
    {
        throw new NotImplementedException();
    }
}