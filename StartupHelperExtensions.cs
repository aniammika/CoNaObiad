using CoNaObiadAPI.EndpointHandlers;
using CoNaObiadAPI.Endpoints;
using CoNaObiadAPI.SqliteContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Runtime.CompilerServices;

namespace CoNaObiadAPI
{
    internal static class StartupHelperExtensions
    {
        public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
        {
            //dbContext
            builder.Services.AddDbContext<DishesDbContext>(o => o.UseSqlite(builder.Configuration["ConnectionStrings:DishesDbConnectionString"]));
            //autoMapper
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            builder.Services.AddProblemDetails();

            //adding authentication
            builder.Services.AddAuthentication().AddJwtBearer();
            builder.Services.AddAuthorization();

            builder.Services.AddAuthorizationBuilder()
                .AddPolicy("RequireAdmin", policy =>
                policy.RequireRole("admin"));


            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(options =>
            {
                options.AddSecurityDefinition("TokenAuth",
                new()
                {
                    Name = "Authorization",
                    Description = "Token-based authentication and authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "Bearer",
                    In = ParameterLocation.Header
                });
                options.AddSecurityRequirement(new()
                 {
                     {
                          new ()
                          {
                              Reference = new OpenApiReference {
                                  Type = ReferenceType.SecurityScheme,
                                  Id = "TokenAuth" }
                          }, new List<string>()}
                 });
            });

            return builder.Build();
        }

        public static WebApplication ConfigurePipeline(this WebApplication app)
        {
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

            //adding documentation
            app.UseSwagger();
            app.UseSwaggerUI();

            //it's not necessary, builder.Services.AddAuthentication().AddJwtBearer(); is enough. but for clarity worth to have.
            app.UseAuthentication();
            app.UseAuthorization();

            DishesEndpoints.Map(app);
            TagsEndpoints.Map(app);
            DishTagEndpoints.Map(app);

            return app;
        }
    }
}
