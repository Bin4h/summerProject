using Application.Models;

namespace Application.Interfaces;

public interface IAlbumService
{
    Task AddAlbumAsync(AlbumModel albumModel);
    Task<List<AlbumModel>> GetAlbumBySingerAsync(int singerId);
}
