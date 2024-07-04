
using Application.Dtos;
using Application.Interfaces;
using Application.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GenreController : ControllerBase
{
    private readonly IGenreService _genreService;
    private readonly IMapper _mapper;

    public GenreController(IGenreService genreService, IMapper mapper)
    {
        _genreService = genreService ?? throw new ArgumentNullException(nameof(genreService));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    [HttpPost]
    [Route("addGenre")]
    public async Task<IActionResult> AddGenre(AddGenreDto addGenreDto)
    {
        GenreModel model = _mapper.Map<GenreModel>(addGenreDto);

        await _genreService.AddGenreAsync(model);

        return Ok();
    }
}
