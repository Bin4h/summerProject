using Application.Models;

namespace Data_Base.Interfaces;

internal interface IAlbumRepository
{
    Task AddAlbumAsync(AlbumModel albumModel);
}
