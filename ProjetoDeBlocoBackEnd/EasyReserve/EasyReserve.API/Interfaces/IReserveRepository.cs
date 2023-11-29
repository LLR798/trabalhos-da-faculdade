using EasyReserve.API.Models;

namespace EasyReserve.API.Interfaces;

public interface IReserveRepository
{
    void CreateReserve(Reserve reserve);
    void UpdateReserve(Reserve reserve);
    void DeleteReserve(Reserve reserve);
    
    Task<Reserve> GetByReserveId(int id);
    Task<IEnumerable<Reserve>> GetAllReservations();
    Task<bool> SaveAllAsync();
}