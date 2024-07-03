using Application.Models;

namespace Application.Interfaces;

public interface IGenreService
{
    Task AddGenreAsync(GenreModel genreModel);
}
