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


    public async Task<Hotel> CreateHotel(Hotel hotel)
    {
        _context.Hotels.Add(hotel);
        await _context.SaveChangesAsync();
        
        return hotel;
    }
    
    public async Task<Hotel> UpdateHotel(Hotel hotel)
    {
        var existingHotel = await _context.Hotels.FindAsync(hotel.HotelId);
        
        if (existingHotel != null)
        {
            _context.Entry(existingHotel).State = EntityState.Detached;
        }

        _context.Hotels.Update(hotel);
        await _context.SaveChangesAsync();
        return hotel;
    }

    public async Task<Hotel> DeleteHotel(int id)
    {
        var hotel = await _context.Hotels.FindAsync(id);

        if (hotel != null)
        {
            _context.Hotels.Remove(hotel);
            await _context.SaveChangesAsync();
        }
        
        return hotel;
    }

    public async Task<Hotel> GetByHotelId(int id)
    {
        return await _context.Hotels.Where(x => x.HotelId == id).FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<Hotel>> GetAllHotels()
    {
        return await _context.Hotels.ToListAsync();
    }
}