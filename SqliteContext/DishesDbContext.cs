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

        modelBuilder.Entity<Dish>()
            .HasOne(e => e.Season)
            .WithMany(e => e.Dishes)
            .HasForeignKey(e => e.SeasonId)
            .IsRequired();

        modelBuilder.Entity<Dish>()
            .HasOne(e => e.PreparationTime)
            .WithMany(e => e.Dishes)
            .HasForeignKey(e => e.PreparationTimeId)
            .IsRequired();

        //modelBuilder.Entity<Season>().HasData(
        //    new Season() { Id = 1, Name = "Winter" },
        //    new Season() { Id = 2, Name = "Spring" },
        //    new Season() { Id = 3, Name = "Summer" },
        //    new Season() { Id = 4, Name = "Autumn" });

        //modelBuilder.Entity<PreparationTime>().HasData(
        //    new PreparationTime() { Id = 1, Time = "Fast" },
        //    new PreparationTime() { Id = 2, Time = "Medium" },
        //    new PreparationTime() { Id = 3, Time = "Slow" },
        //    new PreparationTime() { Id = 4, Time = "Extra-slow" });

        //modelBuilder.Entity<Dish>().HasData(
        //    new Dish() { Id = 1, Name = "Penne z cukinią i szparagami", Description = "Kwestia smaku", PreparationTimeId = 1, SeasonId = 2 },
        //    new Dish() { Id = 2, Name = "Pad thai z tofu i warzywami", Description = "Kwestia smaku", PreparationTimeId = 2, SeasonId = 3 },
        //    new Dish() { Id = 3, Name = "Lasagne bolognese", Description = "Kwestia smaku", PreparationTimeId = 4, SeasonId = 1 },
        //    new Dish() { Id = 4, Name = "Gnocchi zapiekane z mielonym mięsem w sosie pomidorowym", Description = "Kwestia smaku", PreparationTimeId = 1, SeasonId = 1 });
    }
}
