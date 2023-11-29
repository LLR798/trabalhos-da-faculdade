using EasyReserve.API.DTOs;

namespace EasyReserve.API.Services.RoomService;

public interface IRoomService
{
    Task<RoomDTO> CreateRoom(RoomDTO roomDTO);
    Task<RoomDTO> UpdateRoom(RoomDTO roomDTO);
    Task<RoomDTO> DeleteRoom(int id);
    
    Task<RoomDTO> GetByRoomId(int id);
    Task<IEnumerable<RoomDTO>> GetAllRooms();
}