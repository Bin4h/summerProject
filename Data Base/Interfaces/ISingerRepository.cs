using Application.Models;

namespace Data_Base.Interfaces;

public interface ISingerRepository
{
    Task AddSingerAsync(SingerModel singerModel);
}
