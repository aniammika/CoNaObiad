using AutoMapper;
using CoNaObiadAPI.Entities;
using CoNaObiadAPI.Models.Dish;
using CoNaObiadAPI.Models.DishTag;
using CoNaObiadAPI.Models.Tag;
using CoNaObiadAPI.SqliteContext;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoNaObiadAPI.EndpointHandlers
{
    public class DishTagHandlers
    {

        #region addTagToDish
        public static async Task<Results<NotFound, NoContent>> AddTagToDishAsync
                (DishesDbContext dishesDbContext,
                IMapper mapper,
                int dishId,
                int tagId)
        {
            var dishToCheck = await dishesDbContext.Dishes.FirstOrDefaultAsync(d => d.Id == dishId);
            var tagToCheck = await dishesDbContext.Tags.FirstOrDefaultAsync(d => d.Id == tagId);
            if (dishToCheck == null || tagToCheck == null)
            {
                return TypedResults.NotFound();
            }
            dishesDbContext.DishTag.Add(new DishTag { DishesId = dishId, TagsId = tagId });
            await dishesDbContext.SaveChangesAsync();

            return TypedResults.NoContent();
        }
        #endregion

        #region getTagsPerDish
        public static async Task<Ok<List<TagDto>>> GetTagsPerDishAsync
            (DishesDbContext dishesDbContext,
            IMapper mapper, int dishId,
            ILogger<DishTagDto> logger)
        {
            logger.LogInformation("Get tags per dish called");

            var dishTagsForDishId = await dishesDbContext.DishTag.Where(d => d.DishesId == dishId).ToArrayAsync();
            var tagsToReturn = new List<TagDto>();
            foreach (var dishTag in dishTagsForDishId)
            {
                var tagId = dishTag.TagsId;
                //mapper.Map<TDestination>(TSource)
                TagDto tagToReturn = mapper.Map<TagDto>(dishesDbContext.Tags.FirstOrDefault(d => d.Id == tagId));
                tagsToReturn.Add(tagToReturn);
            }

            return TypedResults.Ok(tagsToReturn);
        }
        #endregion
    }
}
