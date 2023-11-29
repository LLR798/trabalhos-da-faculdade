using EasyReserve.API.Models;

namespace EasyReserve.API.Interfaces;

public interface IReserveRepository
{
    Task<Reserve> CreateReserve(Reserve reserve);
    Task<Reserve> UpdateReserve(Reserve reserve);
    Task<Reserve> DeleteReserve(int id);
    
    Task<Reserve> GetByReserveId(int id);
    Task<IEnumerable<Reserve>> GetAllReservations();
}