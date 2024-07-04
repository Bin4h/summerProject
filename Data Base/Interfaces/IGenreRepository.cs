using Application.Models;

namespace Data_Base.Interfaces;

internal interface IGenreRepository
{
    Task AddGenreAsync(GenreModel genreModel);
}
