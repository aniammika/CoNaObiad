using CoNaObiadAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace CoNaObiadAPI.SqliteContext;

public class DishesDbContext : DbContext
{
    public DbSet<Dish> Dishes { get; set; } = null!;
    public DbSet<Tag> Tags { get; set; } = null!;
    public DbSet<DishTag> DishTag { get; set; } = null!;

    public DishesDbContext(DbContextOptions<DishesDbContext> options)
    : base(options)
    {        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dish>()
            .HasMany(e => e.Tags)
            .WithMany(e => e.Dishes)
            .UsingEntity<DishTag>();
    }
}
