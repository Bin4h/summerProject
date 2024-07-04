using Application.Models;
using AutoMapper;
using Data_Base.Entities;
using Data_Base.Interfaces;

namespace Data_Base.Repositories;

public class SingerRepository : BaseRepository<Singer>, ISingerRepository
{
    private readonly Mapper _mapper;
    private readonly ProjectDBContext _dbContext;

    public SingerRepository(Mapper mapper, ProjectDBContext dbContext) : base(dbContext)
    {
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
    }

    public Task AddSingerAsync(SingerModel singerModel)
    {
        Singer entity = _mapper.Map<Singer>(singerModel);

        return AddAsync(entity);
    }
}
