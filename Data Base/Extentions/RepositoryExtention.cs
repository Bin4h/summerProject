using Data_Base.Interfaces;
using Data_Base.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Data_Base.Extentions;

public static class RepositoryExtention
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<ISingerRepository, SingerRepository>();

        return services;
    }
}
