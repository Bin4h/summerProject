using Application.Models;
using AutoMapper;
using Data_Base.Entities;
using Data_Base.Interfaces;

namespace Data_Base.Repositories;

public class GenreRepository : BaseRepository<Genre>, IGenreRepository
{
    private readonly IMapper _mapper;
    private readonly ProjectDBContext _dbContext;

    public GenreRepository(IMapper mapper, ProjectDBContext dbContext) : base(dbContext)
    {
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
    }

    public Task AddGenreAsync(GenreModel genreModel)
    {
        Genre entity = _mapper.Map<Genre>(genreModel);

        return AddAsync(entity);
    }
}