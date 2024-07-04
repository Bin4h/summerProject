using Application.Interfaces;
using Application.Models;
using Data_Base.Interfaces;

namespace Application.Services;

public class SingerService : ISingerService
{
    private readonly ISingerRepository _singerRepository;

    public SingerService(ISingerRepository singerRepository)
    {
        _singerRepository = singerRepository ?? throw new ArgumentNullException(nameof(singerRepository));
    }

    public async Task AddSingerAsync(SingerModel singerModel)
    {
        await _singerRepository.AddSingerAsync(singerModel);
    }
}
