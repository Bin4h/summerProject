using Application.Interfaces;
using Application.Mappers;
using Application.Services;
using Data_Base;
using Microsoft.EntityFrameworkCore;

namespace Project;

public static class Startup
{
    public static void AddDbContext(IServiceCollection services, string connectionString)
    {
        services.AddDbContext<ProjectDBContext>(opt => 
        {
            opt.UseNpgsql(connectionString);
        });
    }
    public static void AddAutoMapper(IServiceCollection services)
    {
        services.AddAutoMapper(typeof(Mapper));
    }
    public static void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<ISingerService, SingerService>();
    }
}
