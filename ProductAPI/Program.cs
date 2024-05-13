using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Product.Application.Bootstrapper;
using Product.Data.Infrastructure.AutoMapper;
using Product.Data.Infrastructure.Bootstrapper;
using Product.Data.Infrastructure.Context;
using Product.Presentation.Api.Infrastructure.Hosting;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
var configuration = GetConfiguration();

#region Auto Mapper Configurations
var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MapperProfile());
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);
#endregion
 builder.Services.AddRepository();
 builder.Services.AddAppService();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
#region DbContext & Settings

#endregion
app.UseRouting();

app.UseHttpsRedirection();

app.UseAuthorization();

#region Swagger
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Enterprise.Events.Api", Version = "v1" });
 
});
#endregion
#region DbContext & Settings
AddCustomDbContext(builder.Services);
#endregion

app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TEST.Api v1"));

app.MapControllers();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.MigrateDbContext<AppDbContext>((context, services) =>
{
    context.Database.Migrate();
    
});
app.Run();

IConfiguration GetConfiguration()
{
    var builder = new ConfigurationBuilder()
        .SetBasePath(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location))
        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        .AddEnvironmentVariables();

    return builder.Build();
}

IServiceCollection AddCustomDbContext(IServiceCollection services)
{
    string connString = configuration["ConnectionString"];
    string envConnString = Environment.GetEnvironmentVariable("ConnectionStrings__DBConString");
    if (!string.IsNullOrWhiteSpace(envConnString))
    {
        connString = envConnString;
    }

    services.AddDbContext<AppDbContext>(options =>
    {
        options.UseSqlServer(connString,
            sqlServerOptionsAction: sqlOptions =>
            {
                sqlOptions.MigrationsAssembly(typeof(Program).GetTypeInfo().Assembly.GetName().Name);
                sqlOptions.EnableRetryOnFailure(maxRetryCount: 15, maxRetryDelay: TimeSpan.FromSeconds(30), errorNumbersToAdd: null);
            });
    },
    ServiceLifetime.Scoped  //Showing explicitly that the DbContext is shared across the HTTP request scope (graph of objects started in the HTTP request)
    );


    return services;
}

