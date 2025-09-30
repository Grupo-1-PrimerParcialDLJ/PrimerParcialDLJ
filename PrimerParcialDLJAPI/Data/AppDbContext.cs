using Microsoft.EntityFrameworkCore;
using PrimerParcialDLJAPI.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<SupportTicket> SupportTickets { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Event> Events { get; set; }  
    
}