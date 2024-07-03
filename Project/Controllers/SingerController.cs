using Application.Dtos;
using Application.Interfaces;
using Application.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;


namespace Project.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SingerController : Controller
{
    private readonly ISingerService _singerService;
    private readonly IMapper _mapper;

    [HttpPost]
    [Route("addSinger")]
    public async Task<IActionResult> AddSinger(AddSingerDto addSingerDto)
    {
        //Преобразовываем с модель с помощью маппера и пробрасываем в сервис

        await _singerService.AddSingerAsync(_mapper.Map<SingerModel>(addSingerDto));

        return Ok();
    }
}
