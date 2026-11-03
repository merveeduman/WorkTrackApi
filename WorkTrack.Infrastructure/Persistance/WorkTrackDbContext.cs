using Microsoft.EntityFrameworkCore;
using WorkTrack.Domain.Entities;

namespace WorkTrack.Infrastructure.Persistence;

public class WorkTrackDbContext : DbContext
{
    public WorkTrackDbContext(
        DbContextOptions<WorkTrackDbContext> options)
        : base(options)
    {
    }

    public DbSet<WorkTask> WorkTasks => Set<WorkTask>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<WorkTask>(entity =>
        {
            entity.HasKey(x => x.Id);

            entity.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(200);

            entity.Property(x => x.Status)
                .HasConversion<string>()
                .HasMaxLength(20)
                .IsRequired();
        });
    }
}