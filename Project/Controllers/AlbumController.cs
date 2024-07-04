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

    [HttpPost]
    [Route("addAlbum")]
    public async Task<IActionResult> AddAlbum(AddAlbumDto addAlbumDto)
    {
        AlbumModel model = _mapper.Map<AlbumModel>(addAlbumDto);

        await _albumService.AddAlbumAsync(model);

        return Ok();
    }
}
