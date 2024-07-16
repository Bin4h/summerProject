using Application.Dtos;
using Application.Models;
using AutoMapper;
using Data.Dtos;
using Data.Models;
using Data_Base.Entities;

namespace Application.Mappers;

public class ProjectMapper : Profile
{
    public ProjectMapper()
    {
        CreateMap<AddSingerDto, SingerModel>().ReverseMap();
        CreateMap<AddAlbumDto, AlbumModel>().ReverseMap();
        CreateMap<AddTrackDto, TrackModel>().ReverseMap();
        CreateMap<AddGenreDto, GenreModel>().ReverseMap();
        CreateMap<AddUserDto, UserModel>().ReverseMap();
        CreateMap<SingerModel, SingerCardDto>().ReverseMap();
        CreateMap<AlbumModel, AlbumDto>().ReverseMap();
        CreateMap<SingerModel, SingerPageDto>().ReverseMap();

        CreateMap<SingerModel, Singer>().ReverseMap();
        CreateMap<AlbumModel, Album>().ReverseMap();
        CreateMap<TrackModel, Track>().ReverseMap();
        CreateMap<GenreModel, Genre>().ReverseMap();
        CreateMap<UserModel, User>().ReverseMap();
    }
}
