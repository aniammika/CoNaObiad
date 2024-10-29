using CoNaObiadAPI.EndpointHandlers;

namespace CoNaObiadAPI.Endpoints
{
    public class TagsEndpoints
    {
        public static void Map(WebApplication app)
        {
            //route groups
            //https://learn.microsoft.com/en-us/aspnet/core/fundamentals/minimal-apis/route-handlers?view=aspnetcore-8.0#route-groups
            var tagsEndpoints = app.MapGroup("/tags").RequireAuthorization();
            var tagsEndpointsWithId = app.MapGroup("/tags/{tagId:guid}").RequireAuthorization();

            tagsEndpoints.MapGet("", TagsHandlers.GetTagsAsync);
            //adding new tag requires admin role
            tagsEndpoints.MapPost("", TagsHandlers.CreateTagAsync).RequireAuthorization("RequireAdmin");
            tagsEndpointsWithId.MapDelete("", TagsHandlers.DeleteTagAsync);
        }
    }
}
