using Ardalis.Specification;
using Ardalis.Specification.EntityFrameworkCore;
using Data_Base.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Data_Base.Repositories;

public abstract class BaseRepository<TEntity> : RepositoryBase<TEntity> where TEntity : class
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
    public override async Task<List<TEntity>> ListAsync(CancellationToken cancellationToken = default) => await base.ListAsync(cancellationToken);
    public override async Task<List<TEntity>> ListAsync(ISpecification<TEntity> specification, CancellationToken cancellation = default) => await base.ListAsync();
    public override async Task<TEntity?> FirstOrDefaultAsync(ISpecification<TEntity> specification, CancellationToken cancellationToken = default) => await base.FirstOrDefaultAsync(specification, cancellationToken);
}
