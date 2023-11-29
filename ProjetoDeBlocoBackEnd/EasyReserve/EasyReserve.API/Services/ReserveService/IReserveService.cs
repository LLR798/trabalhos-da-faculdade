using EasyReserve.API.DTOs;

namespace EasyReserve.API.Services.ReserveService;

public interface IReserveService
{
    Task<ReserveDTO> CreateReserve(ReserveDTO reserveDTO);
    Task<ReserveDTO> UpdateReserve(ReserveDTO reserveDTO);
    Task<ReserveDTO> DeleteReserve(int id);
    
    Task<ReserveDTO> GetByReserveId(int id);
    Task<IEnumerable<ReserveDTO>> GetAllReservations();
}