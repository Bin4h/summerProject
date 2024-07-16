using Application.Models;
using AutoMapper;
using Data_Base.Entities;
using Data_Base.Interfaces;
using Data_Base.Specifications;
using Application.Exceptions;
using Data.Dtos;

namespace Data_Base.Repositories;

public class SingerRepository : BaseRepository<Singer>, ISingerRepository
{
    private readonly IMapper _mapper;
    private readonly ProjectDBContext _dbContext;

    public SingerRepository(IMapper mapper, ProjectDBContext dbContext) : base(dbContext)
    {
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
    }

    public Task AddSingerAsync(SingerModel singerModel)
    {
        Singer entity = _mapper.Map<Singer>(singerModel);

        return AddAsync(entity);
    }
    public async Task<List<SingerModel>> GetSingersAsync()
    {
        List<Singer> singers = await ListAsync();

        return _mapper.Map<List<Singer>, List<SingerModel>>(singers);
    }
    public async Task<SingerModel> GetSingerAsync(int id)
    {
        Singer? singer = await FirstOrDefaultAsync(new GetSingersWithAlbumsByIdSpecification(id));

        if(singer == null)
        {
            throw new ProcessException("Исполнитель не найден");
        }

        return _mapper.Map<Singer?, SingerModel>(singer);
    }
}
