using Application.Interfaces;
using AutoMapper;
using Data.Dtos;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
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
    [HttpPost]
    [Route("authoriseUser")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<bool>> AuthoriseUser([Required]AuthoriseUserDto loginDto)
    {
        try
        {
            UserModel userModel = await _userService.GetUserByLoginAsync(loginDto.Login);
            return Ok(_userService.CheckPassword(loginDto.Password, userModel));
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
