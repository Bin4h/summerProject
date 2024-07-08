using Application.Interfaces;
using Application.Models;
using Data_Base.Interfaces;

namespace Application.Services;

public class AlbumService : IAlbumService
{
    private readonly IAlbumRepository _albumRepository;

    public AlbumService(IAlbumRepository albumRepository)
    {
        _albumRepository = albumRepository ?? throw new ArgumentNullException(nameof(albumRepository));
    }

    public async Task AddAlbumAsync(AlbumModel albumModel) => await _albumRepository.AddAlbumAsync(albumModel);
}
