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

    [HttpPost]
    [Route("addSinger")]
    public async Task<IActionResult> AddSinger(AddSingerDto addSingerDto)
    {
        SingerModel model = _mapper.Map<SingerModel>(addSingerDto);

        await _singerService.AddSingerAsync(model);

        return Ok();
    }
}
