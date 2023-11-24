using AutoMapper;
using EasyReserve.API.DTOs;
using EasyReserve.API.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace EasyReserve.API.Mappings;

public class EntitiesToDTOMappingProfile : Profile
{
    public EntitiesToDTOMappingProfile()
    {
        CreateMap<Hotel, HotelDTO>().ReverseMap();
    }
}