using EasyReserve.API.Models;

namespace EasyReserve.API.Interfaces;

public interface IRoomRepository
{
    Task<Room> CreateRoom(Room room);
    Task<Room> UpdateRoom(Room room);
    Task<Room> DeleteRoom(Room room);
    
    Task<Room> GetByRoomId(int id);
    Task<IEnumerable<Room>> GetAllRooms();
    Task<bool> SaveAllAsync();
}