using Application.Dtos;
using Application.Interfaces;
using Application.Models;
using AutoMapper;
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
        _singerService = singerService ?? throw new ArgumentNullException(nameof(singerService));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    /// <summary>
    /// Метод для добавления мсполнителей в базу данных
    /// </summary>
    /// <param name="addTrackDto"></param>
    /// <returns></returns>
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
}
