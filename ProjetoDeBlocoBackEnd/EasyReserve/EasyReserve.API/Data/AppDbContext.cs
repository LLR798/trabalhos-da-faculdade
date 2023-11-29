using EasyReserve.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyReserve.API.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Client> Clients { get; set; }

    public DbSet<Hotel> Hotels { get; set; }

    public DbSet<Reserve> Reserves { get; set; }

    public DbSet<Room> Rooms { get; set; }
}