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

            tagDishEndpoints.MapPost("{dishId}/{tagId}", DishTagHandlers.AddTagToDishAsync);
            tagDishEndpoints.MapGet("{dishId}", DishTagHandlers.GetTagsPerDishAsync);
        }
    }
}
