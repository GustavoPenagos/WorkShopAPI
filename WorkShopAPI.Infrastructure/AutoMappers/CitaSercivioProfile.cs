using AutoMapper;
using WorkShopAPI.Domain.Context;
using WorkShopAPI.Domain.DTOs;

namespace WorkShopAPI.Infrastructure.AutoMappers
{
    public class CitaSercivioProfile : Profile
    {
        public CitaSercivioProfile()
        {
            CreateMap<CitaServicioDto, CitaServicio>()
                .ReverseMap();
        }
    }
}
