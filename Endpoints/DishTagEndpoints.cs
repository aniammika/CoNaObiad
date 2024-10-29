using CoNaObiadAPI.EndpointFilters;
using CoNaObiadAPI.EndpointHandlers;
using CoNaObiadAPI.EndpointsHandlers;

namespace CoNaObiadAPI.Endpoints
{
    public class DishTagEndpoints
    {
        public static void Map(WebApplication app)
        {
            var tagDishEndpoints = app.MapGroup("/dishesTags").RequireAuthorization();

            tagDishEndpoints.MapPost("{dishId:guid}/{tagId:guid}", DishTagHandlers.AddTagToDishAsync);
            tagDishEndpoints.MapGet("{dishId:guid}", DishTagHandlers.GetTagsPerDishAsync);
        }
    }
}
