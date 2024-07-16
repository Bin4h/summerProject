using Application.Models;
using Data.Dtos;

namespace Data_Base.Interfaces;

public interface ISingerRepository
{
    Task AddSingerAsync(SingerModel singerModel);
    Task<List<SingerModel>> GetSingersAsync();
    Task<SingerModel> GetSingerAsync(int id);
}
