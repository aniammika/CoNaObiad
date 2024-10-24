using CoNaObiadAPI.EndpointFilters;
using CoNaObiadAPI.EndpointsHandlers;

namespace CoNaObiadAPI.Endpoints
{
    public static class DishesEndpoints
    {
        public static void Map(WebApplication app)
        {
            //route groups
            //https://learn.microsoft.com/en-us/aspnet/core/fundamentals/minimal-apis/route-handlers?view=aspnetcore-8.0#route-groups
            var dishesEndpoints = app.MapGroup("/dishes").RequireAuthorization();
            var dishesEndpointsWithId = app.MapGroup("/dishes/{dishId:guid}").RequireAuthorization();

            dishesEndpoints.MapGet("", DishesHandlers.GetDishesAsync);
            dishesEndpointsWithId.MapGet("", DishesHandlers.GetDishAsync).WithName("GetDish");
            dishesEndpoints.MapPost("", DishesHandlers.CreateDishAsync).AddEndpointFilter<EndpointAnnotationsFilter>();
            dishesEndpointsWithId.MapPut("", DishesHandlers.UpdateDishAsync);
            dishesEndpointsWithId.MapDelete("", DishesHandlers.DeleteDishAsync).AddEndpointFilter<LogNotFoundResponseFilter>();
        }
    }
}
