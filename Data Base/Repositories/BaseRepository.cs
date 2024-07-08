using Ardalis.Specification.EntityFrameworkCore;
using Data_Base.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Data_Base.Repositories;

public abstract class BaseRepository<TEntity> : RepositoryBase<TEntity> where TEntity : class, IBaseEntity
{
    private readonly DbContext _dbContext;
    protected BaseRepository(DbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }
    public override async Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        return await base.AddAsync(entity, cancellationToken);
    }
}
