using Application.Dtos;
using Application.Models;
using AutoMapper;

namespace Application.Mappers;

public class SingerMapper : Profile
{
    public SingerMapper()
    {
        CreateMap<AddSingerDto, SingerModel>();
    }
}
