using AgroTrackerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AgroTrackerAPI.Data;

public class AgroDbContext : DbContext
{
    public AgroDbContext(DbContextOptions<AgroDbContext> options) : base(options) { }

    public DbSet<Field> Fields { get; set; }
    public DbSet<Crop> Crops { get; set; }
    public DbSet<FieldworkTask> FieldworkTasks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Konfiguracja relacji Field -> Crops (1:N)
        modelBuilder.Entity<Crop>()
            .HasOne(c => c.Field)
            .WithMany(f => f.Crops)
            .HasForeignKey(c => c.FieldId);

        // Konfiguracja relacji Crop -> FieldworkTasks (1:N)
        modelBuilder.Entity<FieldworkTask>()
            .HasOne(t => t.Crop)
            .WithMany(c => c.FieldworkTasks)
            .HasForeignKey(t => t.CropId);
    }

}