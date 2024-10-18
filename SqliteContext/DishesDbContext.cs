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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        _ = modelBuilder.Entity<Tag>().HasData(
            new(Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "lato"),
            new(Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96"), "wiosna"),
            new(Guid.Parse("c19099ed-94db-44ba-885b-0ad7205d5e40"), "jesien"),
            new(Guid.Parse("0c4dc798-b38b-4a1c-905c-a9e76dbef17b"), "caly rok"),
            new(Guid.Parse("937b1ba1-7969-4324-9ab5-afb0e4d875e6"), "dla dzieci"),
            new(Guid.Parse("7a2fbc72-bb33-49de-bd23-c78fceb367fc"), "dla gosci"),
            new(Guid.Parse("b5f336e2-c226-4389-aac3-2499325a3de9"), "makaron"),
            new(Guid.Parse("c22bec27-a880-4f2a-b380-12dcd99c61fe"), "zapiekanka"),
            new(Guid.Parse("aab31c70-57ce-4b6d-a66c-9c1b094e915d"), "zdrowo"),
            new(Guid.Parse("fef8b722-664d-403f-ae3c-05f8ed7d7a1f"), "wege"),
            new(Guid.Parse("8d5a1b40-6677-4545-b6e8-5ba93efda0a1"), "zupa"),
            new(Guid.Parse("40563e5b-e538-4084-9587-3df74fae21d4"), "pomidory"),
            new(Guid.Parse("f350e1a0-38de-42fe-ada5-ae436378ee5b"), "comfort food"));

        _ = modelBuilder.Entity<Dish>().HasData(
           new(Guid.Parse("eacc5169-b2a7-41ad-92c3-dbb1a5e7af06"),
            "Zapiekanka z kurczaka i brokulow"),
           new(Guid.Parse("fe462ec7-b30c-4987-8a8e-5f7dbd8e0cfa"),
            "Makaron penne z cukinią i szparagami"),
           new(Guid.Parse("b512d7cf-b331-4b54-8dae-d1228d128e8d"),
           "Zupa pomidorowa"),
           new(Guid.Parse("fd630a57-2352-4731-b25c-db9cc7601b16"),
           "Gulasz wieprzowo-wolowy"),
           new(Guid.Parse("98929bd4-f099-41eb-a994-f1918b724b5a"),
           "Quesadilla z kurczakiem i warzywami"));

        _ = modelBuilder
            .Entity<Dish>()
            .HasMany(d => d.Tags)
            .WithMany(i => i.Dishes)
            .UsingEntity(e => e.HasData(
                //zapiekanka z kurczakiem i brokułami
                new { DishesId = Guid.Parse("eacc5169-b2a7-41ad-92c3-dbb1a5e7af06"), TagsId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35") },
                new { DishesId = Guid.Parse("eacc5169-b2a7-41ad-92c3-dbb1a5e7af06"), TagsId = Guid.Parse("937b1ba1-7969-4324-9ab5-afb0e4d875e6") },
                new { DishesId = Guid.Parse("eacc5169-b2a7-41ad-92c3-dbb1a5e7af06"), TagsId = Guid.Parse("b5f336e2-c226-4389-aac3-2499325a3de9") },
                new { DishesId = Guid.Parse("eacc5169-b2a7-41ad-92c3-dbb1a5e7af06"), TagsId = Guid.Parse("c22bec27-a880-4f2a-b380-12dcd99c61fe") },
                //makaron penne
                new { DishesId = Guid.Parse("fe462ec7-b30c-4987-8a8e-5f7dbd8e0cfa"), TagsId = Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96") },
                new { DishesId = Guid.Parse("fe462ec7-b30c-4987-8a8e-5f7dbd8e0cfa"), TagsId = Guid.Parse("b5f336e2-c226-4389-aac3-2499325a3de9") },
                new { DishesId = Guid.Parse("fe462ec7-b30c-4987-8a8e-5f7dbd8e0cfa"), TagsId = Guid.Parse("fef8b722-664d-403f-ae3c-05f8ed7d7a1f") },
                //zupa pomidorowa
                new { DishesId = Guid.Parse("b512d7cf-b331-4b54-8dae-d1228d128e8d"), TagsId = Guid.Parse("0c4dc798-b38b-4a1c-905c-a9e76dbef17b") },
                new { DishesId = Guid.Parse("b512d7cf-b331-4b54-8dae-d1228d128e8d"), TagsId = Guid.Parse("937b1ba1-7969-4324-9ab5-afb0e4d875e6") },
                new { DishesId = Guid.Parse("b512d7cf-b331-4b54-8dae-d1228d128e8d"), TagsId = Guid.Parse("8d5a1b40-6677-4545-b6e8-5ba93efda0a1") },
                new { DishesId = Guid.Parse("b512d7cf-b331-4b54-8dae-d1228d128e8d"), TagsId = Guid.Parse("40563e5b-e538-4084-9587-3df74fae21d4") },
                //gulasz
                new { DishesId = Guid.Parse("98929bd4-f099-41eb-a994-f1918b724b5a"), TagsId = Guid.Parse("0c4dc798-b38b-4a1c-905c-a9e76dbef17b") },
                //quesadilla
                new { DishesId = Guid.Parse("98929bd4-f099-41eb-a994-f1918b724b5a"), TagsId = Guid.Parse("7a2fbc72-bb33-49de-bd23-c78fceb367fc") },
                new { DishesId = Guid.Parse("98929bd4-f099-41eb-a994-f1918b724b5a"), TagsId = Guid.Parse("f350e1a0-38de-42fe-ada5-ae436378ee5b") }
                
                ));

        base.OnModelCreating(modelBuilder);
    }
}
