using AutoMapper;
using EasyReserve.API.DTOs;
using EasyReserve.API.Interfaces;
using EasyReserve.API.Models;

namespace EasyReserve.API.Services.RoomService;

public class RoomService : IRoomService
{
    private readonly IRoomRepository _roomRepository;
    private readonly IMapper _mapper;

    public RoomService(IRoomRepository roomRepository, IMapper mapper)
    {
        _roomRepository = roomRepository;
        _mapper = mapper;
    }

    public async Task<RoomDTO> CreateRoom(RoomDTO roomDTO)
    {
        var room = _mapper.Map<Room>(roomDTO);
        var roomAdded = await _roomRepository.CreateRoom(room);

        return _mapper.Map<RoomDTO>(roomAdded);
    }

    public async Task<RoomDTO> UpdateRoom(RoomDTO roomDTO)
    {
        var room = _mapper.Map<Room>(roomDTO);
        var roomUpdated = await _roomRepository.UpdateRoom(room);

        return _mapper.Map<RoomDTO>(roomUpdated);
    }

    public async Task<RoomDTO> DeleteRoom(int id)
    {
        var roomDeleted = await _roomRepository.DeleteRoom(id);
        return _mapper.Map<RoomDTO>(roomDeleted);
    }

    public async Task<RoomDTO> GetByRoomId(int id)
    {
        var room = await _roomRepository.GetByRoomId(id);
        return _mapper.Map<RoomDTO>(room);
    }

    public async Task<IEnumerable<RoomDTO>> GetAllRooms()
    {
        var rooms = await _roomRepository.GetAllRooms();
        return _mapper.Map<IEnumerable<RoomDTO>>(rooms);
    }
}