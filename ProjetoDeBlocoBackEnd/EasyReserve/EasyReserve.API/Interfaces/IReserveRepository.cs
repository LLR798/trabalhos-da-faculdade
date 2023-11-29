using EasyReserve.API.Models;

namespace EasyReserve.API.Interfaces;

public interface IReserveRepository
{
    Task<Reserve> CreateReserve(Reserve reserve);
    Task<Reserve> UpdateReserve(Reserve reserve);
    Task<Reserve> DeleteReserve(Reserve reserve);
    
    Task<Reserve> GetByReserveId(int id);
    Task<IEnumerable<Reserve>> GetAllReservations();
    Task<bool> SaveAllAsync();
}