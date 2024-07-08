using Application.Interfaces;
using Application.Models;
using Data_Base.Interfaces;

namespace Application.Services;

public class GenreService : IGenreService
{
    private readonly IGenreRepository _genreRepository;

    public GenreService(IGenreRepository genreRepository)
    {
        _genreRepository = genreRepository ?? throw new ArgumentNullException(nameof(genreRepository));
    }

    public async Task AddGenreAsync(GenreModel genreModel) => await _genreRepository.AddGenreAsync(genreModel);
}
