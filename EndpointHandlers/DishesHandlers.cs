using AutoMapper;
using CoNaObiadAPI.Entities;
using CoNaObiadAPI.Models;
using CoNaObiadAPI.SqliteContext;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoNaObiadAPI.EndpointsHandlers
{
    public static class DishesHandlers
    {
        #region getDishes
        public static async Task<Ok<IEnumerable<DishDto>>> GetDishesAsync
            (DishesDbContext dishesDbContext, 
            IMapper mapper, 
            ILogger<DishDto> logger,
            [FromQuery] string? name)
        {
            logger.LogInformation("Get dishes called");

            return TypedResults.Ok(mapper.Map<IEnumerable<DishDto>>(await dishesDbContext.Dishes
                .Where(d => name == null || d.Name.ToLower().Contains(name.ToLower()))
                .ToListAsync()));
        }
        #endregion
        #region getDish
        public static async Task<Results<NotFound, Ok<DishDto>>> GetDishAsync
            (DishesDbContext dishesDbContext, 
            IMapper mapper, 
            Guid dishId)
        {
            var foundDish = await dishesDbContext.Dishes.FirstOrDefaultAsync(d => d.Id == dishId);

            if (foundDish == null)
            {
                Results.NotFound();
            }
            return TypedResults.Ok(mapper.Map<DishDto>(foundDish));
        }
        #endregion
        #region create
        public static async Task<Created<DishDto>> CreateDishAsync
                (DishesDbContext dishesDbContext,
                IMapper mapper,
                [FromBody] DishForCreationDto dishForCreationDto,
                LinkGenerator linkGenerator,
                HttpContext httpContext)
        {
            //mapper.Map<TDestination>(TSource);
            var dishEntity = mapper.Map<Dish>(dishForCreationDto);
            dishesDbContext.Add(dishEntity);
            await dishesDbContext.SaveChangesAsync();

            var dishToReturn = mapper.Map<DishDto>(dishEntity);

            var linkToDish = linkGenerator.GetUriByName(httpContext, "GetDish", new { dishId = dishToReturn.Id });
            return TypedResults.Created(linkToDish, dishToReturn);

            //można też tak
            //return TypedResult.CreatedAtRoute(dishToReturn, "GetDish", new (dishId = dishToReturn.Id });
        }
        #endregion
        #region update
        public static async Task<Results<NotFound, NoContent>> UpdateDishAsync
                (DishesDbContext dishesDbContext,
                IMapper mapper,
                Guid dishId,
                DishForUpdateDto dishForUpdateDto)
        {
            var dishEntity = await dishesDbContext.Dishes.FirstOrDefaultAsync(d => d.Id == dishId);
            if (dishEntity == null)
            {
                return TypedResults.NotFound();
            }
            //autoMapper will overwrites values in the destination object with those in  the source object
            //dishForUpdateDto => source
            //dishEntity => destination
            mapper.Map(dishForUpdateDto, dishEntity);
            await dishesDbContext.SaveChangesAsync();

            return TypedResults.NoContent();
        }
        #endregion
        #region delete
        public static async Task<Results<NotFound, NoContent>> DeleteDishAsync
            (DishesDbContext dishesDbContext,
                Guid dishId)
        {
            var dishEntity = await dishesDbContext.Dishes.FirstOrDefaultAsync(d => d.Id == dishId);
            if (dishEntity == null)
            {
                return TypedResults.NotFound();
            }
            dishesDbContext.Dishes.Remove(dishEntity);
            await dishesDbContext.SaveChangesAsync();
            return TypedResults.NoContent();
        }
        #endregion
    }
}
