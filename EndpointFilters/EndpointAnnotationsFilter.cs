using CoNaObiadAPI.Models.Dish;
using MiniValidation;

namespace CoNaObiadAPI.EndpointFilters
{
    public class EndpointAnnotationsFilter : IEndpointFilter
    {
        public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
        {
            var dishForCreationDto = context.GetArgument<DishForCreationDto>(2);

            //TryValidate will be false if validation fails
            if(!MiniValidator.TryValidate(dishForCreationDto, out var validationErrors))
            {
                return TypedResults.ValidationProblem(validationErrors);
            }
            return await next(context);
        }
    }
}
