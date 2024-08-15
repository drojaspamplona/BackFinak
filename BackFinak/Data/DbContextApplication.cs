using BackFinak.Models;
using Microsoft.EntityFrameworkCore;

namespace BackFinak.Data;

public class DbContextApplication : DbContext
{
    public DbContextApplication(DbContextOptions<DbContextApplication> options)
        : base(options)
    {
    }

    public DbSet<EventLog> EventLogs { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EventLog>() 
            .ToTable("EventLog", "Audit").
            HasKey("IdEventLog");
    }
}