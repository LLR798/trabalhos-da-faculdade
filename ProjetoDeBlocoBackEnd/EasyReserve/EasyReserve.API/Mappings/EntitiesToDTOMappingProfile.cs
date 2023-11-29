using AutoMapper;
using EasyReserve.API.DTOs;
using EasyReserve.API.Models;

namespace EasyReserve.API.Mappings;

public class EntitiesToDTOMappingProfile : Profile
{
    public EntitiesToDTOMappingProfile()
    {
        CreateMap<Hotel, HotelDTO>().ReverseMap();
    }
}