using Microsoft.EntityFrameworkCore;
using ThrashShop.Models;

namespace ThrashShop.Data;

public class AppDbContext : DbContext
{
    public DbSet<Skate> Skates { get; set; }
    
    protected override void OnConfiguring
    (
        DbContextOptionsBuilder optionsBuilder
    )
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
        string conn = config.GetConnectionString("DefaultConnection");
        optionsBuilder.UseSqlServer(conn);
    }
}