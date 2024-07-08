using Application.Dtos;
using Application.Interfaces;
using Application.Models;
using AutoMapper;
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
}
