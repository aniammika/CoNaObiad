using CoNaObiadAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoNaObiadAPI.SqliteContext;

public class DishesDbContext : DbContext
{
    public DbSet<Dish> Dishes { get; set; } = null!;
    public DbSet<Tag> Tags { get; set; } = null!;

    public DishesDbContext(DbContextOptions<DishesDbContext> options)
    : base(options)
    {        
    }
}
