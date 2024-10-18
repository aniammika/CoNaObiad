using AutoMapper;
using CoNaObiadAPI.Models;
using CoNaObiadAPI.SqliteContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//dbContext
builder.Services.AddDbContext<DishesDbContext>(o => o.UseSqlite(builder.Configuration["ConnectionStrings:DishesDbConnectionString"]));
//autoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();


app.MapGet("/dishes", async (DishesDbContext dishesDbContext, IMapper mapper) =>
{
    return mapper.Map<DishDto>(await dishesDbContext.Dishes.ToListAsync());
});
app.MapGet("/dishes/{dishId:guid}", async (DishesDbContext dishesDbContext, IMapper mapper, Guid dishId) =>
{
    return mapper.Map<DishDto>(await dishesDbContext.Dishes.FirstOrDefaultAsync(d => d.Id == dishId));
});

app.MapGet("/tag", async (DishesDbContext dishesDbContext) =>
{
    return await dishesDbContext.Tags.ToListAsync();
}); ;

app.Run();
