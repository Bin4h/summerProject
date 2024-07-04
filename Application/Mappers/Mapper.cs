using Application.Dtos;
using Application.Models;
using AutoMapper;

namespace Application.Mappers;

public class Mapper : Profile
{
    public Mapper()
    {
        CreateMap<AddSingerDto, SingerModel>();
    }
}
