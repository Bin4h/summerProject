using Data.Models;

namespace Application.Interfaces;

public interface IUserService
{
    public Task AddUserAsync(UserModel user);
    public Task<UserModel> GetUserAsync(int id);
    public Task<UserModel> GetUserByLoginAsync(string login);
    public bool CheckPassword(string password, UserModel user);
}
