using Application.Interfaces;
using Application.Mappers;
using Application.Services;
using AutoMapper;
using Data_Base;
using Data_Base.Interfaces;
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
        //services.AddAutoMapper(typeof(Mapper));
        services.AddSingleton<IMapper, ProjectMapper>();
    }
    public static void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<ISingerService, SingerService>();
    }
}
