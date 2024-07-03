using Application.Models;

namespace Application.Interfaces;

public interface IAlbumService
{
    Task AddAlbumAsync(AlbumModel albumModel);
}
