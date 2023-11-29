using EasyReserve.API.Data;
using EasyReserve.API.Interfaces;
using EasyReserve.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyReserve.API.Repositories;

public class HotelRepository : IHotelRepository
{
    private readonly AppDbContext _context;

    public HotelRepository(AppDbContext context)
    {
        _context = context;
    }


    public void CreateHotel(Hotel hotel)
    {
        _context.Hotels.Add(hotel);
    }

    public void UpdateHotel(Hotel hotel)
    {
        _context.Entry(hotel).State = EntityState.Modified;
    }

    public void DeleteHotel(Hotel hotel)
    {
        _context.Hotels.Remove(hotel);
    }

    public async Task<Hotel> GetByHotelId(int id)
    {
        return await _context.Hotels.Where(x => x.HotelId == id).FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<Hotel>> GetAllHotels()
    {
        return await _context.Hotels.ToListAsync();
    }

    public async Task<bool> SaveAllAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }
}