using Application.Dtos;
using Application.Models;
using AutoMapper;
using Data_Base.Entities;

namespace Application.Mappers;

public class ProjectMapper : Profile
{
    public ProjectMapper()
    {
        CreateMap<AddSingerDto, SingerModel>();
        CreateMap<AddAlbumDto, AlbumModel>();
        CreateMap<AddTrackDto, TrackModel>();
        CreateMap<AddGenreDto, GenreModel>();

        CreateMap<SingerModel, Singer>().ReverseMap();
        CreateMap<AlbumModel, Album>();
        CreateMap<TrackModel, Track>();
        CreateMap<GenreModel, Genre>();

    }
}
