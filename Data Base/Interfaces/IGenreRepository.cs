using Application.Models;

namespace Data_Base.Interfaces;


public interface IGenreRepository
{
    Task AddGenreAsync(GenreModel genreModel);
}
