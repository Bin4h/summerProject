using Application.Models;
using AutoMapper;
using Data_Base.Entities;
using Data_Base.Interfaces;

namespace Data_Base.Repositories;

public class AlbumRepository : BaseRepository<Album>, IAlbumRepository
{
    private readonly IMapper _mapper;
    private readonly ProjectDBContext _dbContext;

    public AlbumRepository(IMapper mapper, ProjectDBContext dbContext) : base(dbContext)
    {
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
    }

    public Task AddAlbumAsync(AlbumModel albumModel)
    {
        Album entity = _mapper.Map<Album>(albumModel);

        return AddAsync(entity);
    }
    public async Task<List<AlbumModel>> GetAlbumBySingerAsync(int SingerId)
    {
        //List<Album> entity = await ListAsync( ,SingerId);
        return default; //_mapper.Map<List<AlbumModel>>(entity);
    }
}
