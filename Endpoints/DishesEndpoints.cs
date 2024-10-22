using AutoMapper;
using CoNaObiadAPI.EndpointsHandlers;
using CoNaObiadAPI.Entities;
using CoNaObiadAPI.Models;
using CoNaObiadAPI.SqliteContext;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoNaObiadAPI.Endpoints
{
    public static class DishesEndpoints
    {
        public static void Map(WebApplication app)
        {
            //route groups
            //https://learn.microsoft.com/en-us/aspnet/core/fundamentals/minimal-apis/route-handlers?view=aspnetcore-8.0#route-groups
            var dishesEndpoints = app.MapGroup("/dishes");
            var dishesEndpointsWithId = app.MapGroup("/dishes/{dishId:guid}");

            dishesEndpoints.MapGet("", DishesHandlers.GetDishesAsync);
            dishesEndpointsWithId.MapGet("", DishesHandlers.GetDishAsync).WithName("GetDish");
            dishesEndpoints.MapPost("", DishesHandlers.CreateDishAsync);
            dishesEndpointsWithId.MapPut("", DishesHandlers.UpdateDishAsync);
            dishesEndpointsWithId.MapDelete("", DishesHandlers.DeleteDishAsync);
        }
    }
}
