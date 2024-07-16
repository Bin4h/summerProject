using Application.Dtos;
using Application.Interfaces;
using Application.Models;
using AutoMapper;
using Data_Base.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AlbumController : ControllerBase
{
    private readonly IAlbumService _albumService;
    private readonly IMapper _mapper;

    public AlbumController(IAlbumService AlbumService, IMapper mapper)
    {
        _albumService = AlbumService ?? throw new ArgumentNullException(nameof(AlbumService));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }
    /// <summary>
    /// Метод для добавления альбомомов в базу данных
    /// </summary>
    /// <param name="addTrackDto"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("addAlbum")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> AddAlbum(AddAlbumDto addAlbumDto)
    {
        try
        {
            AlbumModel model = _mapper.Map<AlbumModel>(addAlbumDto);

            await _albumService.AddAlbumAsync(model);

            return Ok();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    [HttpGet]
    [Route("getAlbumBySInger/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<ActionResult<SingerModel>> GetAlbumBySinger(int id)
    {
        try
        {
            List<AlbumModel> model = await _albumService.GetAlbumBySingerAsync(id);
            List<AddAlbumDto> album = _mapper.Map<List<AddAlbumDto>>(model);
            return album == null ? NoContent() : Ok(album);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
