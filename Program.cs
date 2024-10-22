using AutoMapper;
using CoNaObiadAPI.Endpoints;
using CoNaObiadAPI.Models;
using CoNaObiadAPI.SqliteContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

//build with help of https://app.pluralsight.com/library/courses/asp-dot-net-core-7-building-minimal-apis/description
//Building ASP.NET Core Minimal APIs
//by Kevin Dockx
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//dbContext
builder.Services.AddDbContext<DishesDbContext>(o => o.UseSqlite(builder.Configuration["ConnectionStrings:DishesDbConnectionString"]));
//autoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

DishesEndpoints.Map(app);
TagsEndpoints.Map(app);

app.MapGet("/tag", async (DishesDbContext dishesDbContext) =>
{
    return await dishesDbContext.Tags.ToListAsync();
}); ;

app.Run();
