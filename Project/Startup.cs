using Application.Mappers;
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
        services.AddAutoMapper(typeof(SingerMapper));
    }
}
