using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.db;

public class HotelDbContext : DbContext
{
    public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options)
    {
        
    }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<Guest> Guests { get; set; }
    public DbSet<Rooms> Rooms { get; set; }
    
}