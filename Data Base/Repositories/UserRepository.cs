using Application.Exceptions;
using AutoMapper;
using Data.Models;
using Data_Base.Entities;
using Data_Base.Interfaces;
using Data_Base.Specifications;

namespace Data_Base.Repositories;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    private readonly IMapper _mapper;
    private readonly ProjectDBContext _dbContext;

    public UserRepository(IMapper mapper, ProjectDBContext dbContext) : base(dbContext)
    {
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
    }
    public Task AddUserAsync(UserModel userModel)
    {
        User entity = _mapper.Map<User>(userModel);

        return AddAsync(entity);
    }
    public async Task<UserModel> GetUserAsync(int id)
    {
        User? user = await GetByIdAsync(id);

        if (user == null)
        {
            throw new ProcessException("User не найден");
        }

        return _mapper.Map<User?, UserModel>(user);
    }
    public async Task<UserModel> GetUserByLoginAsync(string login)
    {
        User? user = await FirstOrDefaultAsync(new GetUserByLogin(login));
        if (user == null)
        {
            throw new ProcessException($"Could not find user {login}");
        }
        return(_mapper.Map<User?, UserModel>(user));
    }
}
