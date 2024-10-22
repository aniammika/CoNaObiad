using AutoMapper;
using CoNaObiadAPI.Entities;
using CoNaObiadAPI.Models;
using CoNaObiadAPI.SqliteContext;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace CoNaObiadAPI.Endpoints
{
    public class TagsEndpoints
    {
        public static void Map(WebApplication app)
        {
            //route groups
            //https://learn.microsoft.com/en-us/aspnet/core/fundamentals/minimal-apis/route-handlers?view=aspnetcore-8.0#route-groups
            var tagsEndpoints = app.MapGroup("/tags");
            var tagsPerDish = app.MapGroup("/dishes/{dishId}/tags");

            tagsEndpoints.MapGet("", async Task<Ok<IEnumerable<TagDto>>> (DishesDbContext dishesDbContext, IMapper mapper) =>
            {
                return TypedResults.Ok(mapper.Map<IEnumerable<TagDto>>(await dishesDbContext.Tags.ToListAsync()));
            });

            tagsPerDish.MapGet("", async Task<Ok<IEnumerable<TagDto>>> (DishesDbContext dishesDbContext, IMapper mapper, Guid dishId) =>
            {
                return TypedResults.Ok(mapper.Map<IEnumerable<TagDto>>((await dishesDbContext.Dishes
                    .Include(d => d.Tags)
                    .FirstOrDefaultAsync(d => d.Id == dishId))?.Tags));
            });
        }
    }
}
