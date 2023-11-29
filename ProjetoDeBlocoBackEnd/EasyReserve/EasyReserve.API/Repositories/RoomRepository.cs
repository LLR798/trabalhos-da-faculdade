using EasyReserve.API.Data;
using EasyReserve.API.Interfaces;
using EasyReserve.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyReserve.API.Repositories;

public class RoomRepository : IRoomRepository
{
    private readonly AppDbContext _context;

    public RoomRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Room> CreateRoom(Room room)
    {
        _context.Rooms.Add(room);
        await _context.SaveChangesAsync();
        
        return room;
    }

    public async Task<Room> UpdateRoom(Room room)
    {
        var existingRoom = await _context.Rooms.FindAsync(room.RoomId);
        
        if (existingRoom != null)
        {
            _context.Entry(existingRoom).State = EntityState.Detached;
        }

        _context.Rooms.Update(room);
        await _context.SaveChangesAsync();
        return room;
    }

    public async Task<Room> DeleteRoom(int id)
    {
        var room = await _context.Rooms.FindAsync(id);

        if (room != null)
        {
            _context.Rooms.Remove(room);
            await _context.SaveChangesAsync();
        }
        
        return room;
    }

    public async Task<Room> GetByRoomId(int id)
    {
        return await _context.Rooms.Where(x => x.RoomId == id).FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<Room>> GetAllRooms()
    {
        return await _context.Rooms.ToListAsync();
    }
}