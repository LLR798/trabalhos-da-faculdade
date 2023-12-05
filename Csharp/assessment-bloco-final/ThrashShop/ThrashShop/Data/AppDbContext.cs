using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ThrashShop.Models;

namespace ThrashShop.Data;

public class AppDbContext : IdentityDbContext
{
    public DbSet<Skate> Skates { get; set; }
    public DbSet<Marca> Marcas { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
    
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