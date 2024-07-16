using Application.Dtos;
using Application.Exceptions;
using Application.Interfaces;
using Application.Models;
using AutoMapper;
using Data.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SingerController : ControllerBase
{
    private readonly ISingerService _singerService;
    private readonly IMapper _mapper;

    public SingerController(ISingerService singerService, IMapper mapper)
    {
        _singerService = singerService;
        _mapper = mapper;
    }



    /// <summary>
    /// Метод для добавления мсполнителей в базу данных
    /// </summary>
    /// <param name="addTrackDto">Модель с входными данными</param>
    [HttpPost]
    [Route("addSinger")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> AddSinger(AddSingerDto addSingerDto)
    {
        try
        {
            SingerModel model = _mapper.Map<SingerModel>(addSingerDto);

            await _singerService.AddSingerAsync(model);

            return Ok();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    /// <summary>
    /// Метод извлечения списка исполнителей
    /// </summary>
    /// <returns>Возвращает список из объектов исполнителей</returns>
    [HttpGet]
    [Route("getSingerList")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<ActionResult<List<SingerCardDto>>> GetSingerList()
    {
        try
        {
            List<SingerModel> modelList = await _singerService.GetSingersAsync();
            List<SingerCardDto> singerList = _mapper.Map<List<SingerCardDto>>(modelList);
            return !singerList.Any() ? NoContent() : Ok(singerList);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    /// <summary>
    /// Метод извлечения исполнителя
    /// </summary>
    /// <param name="id">Id исполнителя</param>
    /// <returns>Возвращает исполнителя по указанному id</returns>
    [HttpGet]
    [Route("getSinger/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<ActionResult<SingerPageDto>> GetSinger(int id)
    {
        try
        {
            SingerModel model = await _singerService.GetSingerAsync(id);

            SingerPageDto singer = _mapper.Map<SingerPageDto>(model);

            return singer == null ? NoContent() : Ok(singer);
        }
        catch(ProcessException ex)
        {
            return BadRequest(ex.Message);
        }
        catch ( Exception ex )
        {
            throw ex;
        }
    }
}
