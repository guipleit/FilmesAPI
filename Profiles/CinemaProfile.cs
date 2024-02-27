using AutoMapper;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles
{
    public class CinemaProfile : Profile
    {
        public CinemaProfile()
        {
            CreateMap<Cinema, CreateCinemaDto>();
            CreateMap<CreateCinemaDto, Cinema>();
            CreateMap<Cinema, ReadCinemaDto>()
                .ForMember(cinemaDto => cinemaDto.Address,
                    opt => opt.MapFrom(cinema => cinema.Address))
                .ForMember(cinemaDto => cinemaDto.Sessions,
                    opt => opt.MapFrom(cinema => cinema.Sessions));
            CreateMap<UpdateCinemaDto, Cinema>();
        }
    }
}
