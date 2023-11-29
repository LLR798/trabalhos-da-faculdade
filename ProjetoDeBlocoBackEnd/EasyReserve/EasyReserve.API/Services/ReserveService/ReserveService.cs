using AutoMapper;
using EasyReserve.API.DTOs;
using EasyReserve.API.Interfaces;
using EasyReserve.API.Models;

namespace EasyReserve.API.Services.ReserveService;

public class ReserveService : IReserveService
{
    private readonly IReserveRepository _reserveRepository;
    private readonly IMapper _mapper;

    public ReserveService(IReserveRepository reserveRepository, IMapper mapper)
    {
        _reserveRepository = reserveRepository;
        _mapper = mapper;
    }

    public async Task<ReserveDTO> CreateReserve(ReserveDTO reserveDTO)
    {
        var reserve = _mapper.Map<Reserve>(reserveDTO);
        var reserveAdded = await _reserveRepository.CreateReserve(reserve);

        return _mapper.Map<ReserveDTO>(reserveAdded);
    }

    public async Task<ReserveDTO> UpdateReserve(ReserveDTO reserveDTO)
    {
        var reserve = _mapper.Map<Reserve>(reserveDTO);
        var reserveUpdated = await _reserveRepository.UpdateReserve(reserve);

        return _mapper.Map<ReserveDTO>(reserveUpdated);
    }

    public async Task<ReserveDTO> DeleteReserve(int id)
    {
        var reserveDeleted = await _reserveRepository.DeleteReserve(id);
        return _mapper.Map<ReserveDTO>(reserveDeleted);
    }

    public async Task<ReserveDTO> GetByReserveId(int id)
    {
        var reserve = await _reserveRepository.GetByReserveId(id);
        return _mapper.Map<ReserveDTO>(reserve);

    }

    public async Task<IEnumerable<ReserveDTO>> GetAllReservations()
    {
        var reservations = await _reserveRepository.GetAllReservations();
        return _mapper.Map<IEnumerable<ReserveDTO>>(reservations);
    }
}