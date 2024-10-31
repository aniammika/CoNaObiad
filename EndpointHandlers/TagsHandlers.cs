using AutoMapper;
using CoNaObiadAPI.Entities;
using CoNaObiadAPI.Models;
using CoNaObiadAPI.Models.Dish;
using CoNaObiadAPI.Models.Tag;
using CoNaObiadAPI.SqliteContext;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace CoNaObiadAPI.EndpointHandlers
{
    public class TagsHandlers
    {
        #region tags
        public static async Task<Ok<IEnumerable<TagDto>>> GetTagsAsync
            (DishesDbContext dishesDbContext,
            IMapper mapper,
            ILogger<TagDto> logger,
            [FromQuery] string? name)
        {
            logger.LogInformation("Get tags called");

            return TypedResults.Ok(mapper.Map<IEnumerable<TagDto>>(await dishesDbContext.Tags
                                .Where(d => name == null || d.Name.ToLower().Contains(name.ToLower())).ToListAsync()));
        }
        #endregion

        #region create
        public static async Task<Created<TagDto>> CreateTagAsync
                    (DishesDbContext dishesDbContext,
                    IMapper mapper,
                    [FromBody] TagForCreationDto tagForCreationDto,
                    LinkGenerator linkGenerator,
                    HttpContext httpContext)
        {
            //mapper.Map<TDestination>(TSource);
            var tagEntity = mapper.Map<Tag>(tagForCreationDto);
            dishesDbContext.Add(tagEntity);
            await dishesDbContext.SaveChangesAsync();

            var tagToReturn = mapper.Map<TagDto>(tagEntity);

            var linkToDish = linkGenerator.GetUriByName(httpContext, "GetTag", new { dishId = tagToReturn.Id });
            return TypedResults.Created(linkToDish, tagToReturn);
        }
        #endregion

        #region delete
        public static async Task<Results<NotFound, NoContent>> DeleteTagAsync
            (DishesDbContext dishesDbContext,
                int tagId)
        {
            var tagEntity = await dishesDbContext.Tags.FirstOrDefaultAsync(d => d.Id == tagId);
            if (tagEntity == null)
            {
                return TypedResults.NotFound();
            }
            dishesDbContext.Tags.Remove(tagEntity);
            await dishesDbContext.SaveChangesAsync();
            return TypedResults.NoContent();
        }
        #endregion
    }
}
