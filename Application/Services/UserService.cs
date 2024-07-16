using Application.Interfaces;
using Data.Models;
using Data_Base.Interfaces;
using System.Security.Cryptography;

namespace Application.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly PasswordService _passwordService;
    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
        _passwordService = new PasswordService();
    }
    public async Task AddUserAsync(UserModel model)
    {
        model.Password = HashPassword(model.Password);
        await _userRepository.AddUserAsync(model); 
    }
    public async Task<UserModel> GetUserAsync(int id) => await _userRepository.GetUserAsync(id);
    public async Task<UserModel> GetUserByLoginAsync(string login) => await _userRepository.GetUserByLoginAsync(login);
    public string HashPassword(string password)
    {
        string hashedPassword = _passwordService.HashPassword(password);
        return hashedPassword;
    }
    public bool CheckPassword(string inputPassword, UserModel user) => _passwordService.VerifyPassword(user.Password, inputPassword);
}
