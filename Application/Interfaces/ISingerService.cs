using Application.Models;

namespace Application.Interfaces;

public interface ISingerService
{
    Task AddSingerAsync(SingerModel singerModel);
    Task<List<SingerModel>> GetSingersAsync();
}
