using Application.Interfaces;
using AutoMapper;
using Data.Dtos;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace Project.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly IMapper _mapper;

    public UserController(IUserService userService, IMapper mapper)
    {
        _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }
    /// <summary>
    /// Метод добавления пользователя
    /// </summary>
    /// <param name="userDto">Модель пользователя</param>
    [HttpGet]
    [Route("addUser/{login}/{password}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> AddUser(string login, string password)
    {
        try
        {
            AddUserDto userDto = new AddUserDto();
            userDto.Login = login;
            userDto.Password = password;
            userDto.Role = "User";

            UserModel userModel = _mapper.Map<UserModel>(userDto);
            await _userService.AddUserAsync(userModel);
            return Ok();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    /// <summary>
    /// Авторизация пользователя
    /// </summary>
    /// <param name="login">Логин</param>
    /// <param name="password">Пароль</param>
    /// <returns>Проверка для авторизации</returns>
    [HttpGet]
    [Route("authoriseUser/{login}/{password}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<bool> AuthoriseUser(string login, string password)
    {
        UserModel userModel = await _userService.GetUserByLoginAsync(login);
        if (_userService.CheckPassword(password, userModel))
            return true;
        else 
            return false;
    }
}
