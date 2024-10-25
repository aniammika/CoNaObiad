using CoNaObiadAPI;
using CoNaObiadAPI.Endpoints;
using CoNaObiadAPI.SqliteContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

//build with help of https://app.pluralsight.com/library/courses/asp-dot-net-core-7-building-minimal-apis/description
//Building ASP.NET Core Minimal APIs
//by Kevin Dockx
var builder = WebApplication.CreateBuilder(args);

var app = builder.ConfigureServices().ConfigurePipeline();

app.Run();
