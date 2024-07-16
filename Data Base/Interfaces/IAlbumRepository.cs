using Application.Models;

namespace Data_Base.Interfaces;


public interface IAlbumRepository
{
    Task AddAlbumAsync(AlbumModel albumModel);
    Task<List<AlbumModel>> GetAlbumBySingerAsync(int singerId);
}
