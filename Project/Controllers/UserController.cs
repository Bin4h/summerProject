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
    [HttpPost]
    [Route("addUser")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> AddUser(AddUserDto userDto)
    {
        try
        {

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
    [Route("authoriseUser")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<ActionResult<UserModel>> AuthoriseUser(string login, string password)
    {
        UserModel userModel = await _userService.GetUserByLoginAsync(login);
        if (_userService.CheckPassword(password, userModel))
            return Ok();
        else 
            return NotFound();
    }
}
