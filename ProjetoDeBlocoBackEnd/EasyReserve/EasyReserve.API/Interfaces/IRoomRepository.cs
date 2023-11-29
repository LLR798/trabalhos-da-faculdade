using EasyReserve.API.Models;

namespace EasyReserve.API.Interfaces;

public interface IRoomRepository
{
    void CreateRoom(Room room);
    void UpdateRoom(Room room);
    void DeleteRoom(Room room);
    
    Task<Room> GetByRoomId(int id);
    Task<IEnumerable<Room>> GetAllRooms();
    Task<bool> SaveAllAsync();
}