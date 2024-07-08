﻿using Application.Dtos;
using Application.Interfaces;
using Application.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TrackController : ControllerBase
{
    private readonly ITrackService _trackService;
    private readonly IMapper _mapper;

    public TrackController(ITrackService TrackService, IMapper mapper)
    {
        _trackService = TrackService ?? throw new ArgumentNullException(nameof(TrackService));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }
    /// <summary>
    /// Метод для добавления треков в базу данных
    /// </summary>
    /// <param name="addTrackDto"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("addTrack")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> AddTrack(AddTrackDto addTrackDto)
    {
        try
        {
            TrackModel model = _mapper.Map<TrackModel>(addTrackDto);

            await _trackService.AddTrackAsync(model);

            return Ok();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
