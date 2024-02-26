using AutoMapper;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile() 
        { 
            CreateMap<Address, CreateAddressDto>();
            CreateMap<CreateAddressDto, Address>();
            CreateMap<ReadAddressDto, Address>();
            CreateMap<Address, ReadAddressDto>();
        }
    }
}
