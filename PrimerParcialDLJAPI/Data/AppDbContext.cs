using Microsoft.EntityFrameworkCore;
using PrimerParcialDLJAPI.Models;

namespace PrimerParcialDLJAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<SupportTicket> SupportTickets { get; set; }
    }
}