using AutoMapper;
using CoNaObiadAPI.Endpoints;
using CoNaObiadAPI.Models;
using CoNaObiadAPI.SqliteContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

//build with help of https://app.pluralsight.com/library/courses/asp-dot-net-core-7-building-minimal-apis/description
//Building ASP.NET Core Minimal APIs
//by Kevin Dockx
var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
//dbContext
builder.Services.AddDbContext<DishesDbContext>(o => o.UseSqlite(builder.Configuration["ConnectionStrings:DishesDbConnectionString"]));
//autoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddProblemDetails();

var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler();
    //app.UseExceptionHandler(configureApplicationBuilder =>
    //{
    //    configureApplicationBuilder.Run(
    //        async context =>
    //        {
    //            context.Response.StatusCode = (int)
    //            HttpStatusCode.InternalServerError;
    //            context.Response.ContentType = "text/html";
    //            await context.Response.WriteAsync("Oooops, something went terribly wrong :(");
    //        });
    //});
}
// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

DishesEndpoints.Map(app);
TagsEndpoints.Map(app);

app.Run();
