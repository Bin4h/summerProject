using Data.Models;

namespace Data_Base.Interfaces;

public interface IUserRepository
{
    public Task AddUserAsync(UserModel user);
    public Task<UserModel> GetUserAsync(int id);
    public Task<UserModel> GetUserByLoginAsync(string login);
}
