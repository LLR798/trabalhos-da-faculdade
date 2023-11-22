using EasyReserve.API.Data;
using EasyReserve.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyReserve.API.Services.HotelService;

public class HotelService : IHotelService
{
    private readonly EasyReserveDbContext _context;

    public HotelService(EasyReserveDbContext context)
    {
        _context = context;
    }


    public void Create(Hotel hotel)
    {
        _context.Hotels.Add(hotel);
    }

    public async Task<Hotel> GetById(int id)
    {
        return await _context.Hotels.SingleOrDefaultAsync(x => x.HotelId == id);
    }

    public async Task<IEnumerable<Hotel>> GetAllHotels()
    {
        return await _context.Hotels.ToListAsync();
    }

    public void Update(Hotel hotel)
    {
        _context.Entry(hotel).State = EntityState.Modified;
    }

    public void Delete(Hotel hotel)
    {
        _context.Hotels.Remove(hotel);
    }

    public async Task<bool> SaveAllAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }
}