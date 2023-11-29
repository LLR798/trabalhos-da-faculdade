using EasyReserve.API.Data;
using EasyReserve.API.Interfaces;
using EasyReserve.API.Models;

namespace EasyReserve.API.Repositories;

public class RoomRepository : IRoomRepository
{
    private readonly AppDbContext _context;

    public RoomRepository(AppDbContext context)
    {
        _context = context;
    }


    public Task<Room> CreateRoom(Room room)
    {
        throw new NotImplementedException();
    }

    public Task<Room> UpdateRoom(Room room)
    {
        throw new NotImplementedException();
    }

    public Task<Room> DeleteRoom(Room room)
    {
        throw new NotImplementedException();
    }

    public Task<Room> GetByRoomId(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Room>> GetAllRooms()
    {
        throw new NotImplementedException();
    }

    public Task<bool> SaveAllAsync()
    {
        throw new NotImplementedException();
    }
}