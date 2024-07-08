using Application.Models;
using AutoMapper;
using Data_Base.Entities;
using Data_Base.Interfaces;

namespace Data_Base.Repositories;

public class TrackRepository : BaseRepository<Track>, ITrackRepository
{
    private readonly IMapper _mapper;
    private readonly ProjectDBContext _dbContext;

    public TrackRepository(IMapper mapper, ProjectDBContext dbContext) : base(dbContext)
    {
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
    }

    public Task AddTrackAsync(TrackModel trackModel)
    {
        Track entity = _mapper.Map<Track>(trackModel);

        return AddAsync(entity);
    }
}

