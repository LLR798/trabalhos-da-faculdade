using EasyReserve.API.Data;
using EasyReserve.API.Interfaces;
using EasyReserve.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyReserve.API.Repositories;

public class ReserveRepository : IReserveRepository
{
    private readonly AppDbContext _context;

    public ReserveRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Reserve> CreateReserve(Reserve reserve)
    {
        _context.Reserves.Add(reserve);
        await _context.SaveChangesAsync();
        
        return reserve;
    }

    public async Task<Reserve> UpdateReserve(Reserve reserve)
    {
        var existingReserve = await _context.Reserves.FindAsync(reserve.ReserveId);
        
        if (existingReserve != null)
        {
            _context.Entry(existingReserve).State = EntityState.Detached;
        }
        
        _context.Reserves.Update(reserve);
        await _context.SaveChangesAsync();
        return reserve;
    }

    public async Task<Reserve> DeleteReserve(int id)
    {
        var reserve = await _context.Reserves.FindAsync(id);

        if (reserve != null)
        {
            _context.Reserves.Remove(reserve);
            await _context.SaveChangesAsync();
        }
        
        return reserve;
    }


    public async Task<Reserve> GetByReserveId(int id)
    {
        return await _context.Reserves.Where(x => x.ReserveId == id).FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<Reserve>> GetAllReservations()
    {
        return await _context.Reserves.ToListAsync();
    }
}