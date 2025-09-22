using AutoMapper;
using WorkShopAPI.Domain.Context;
using WorkShopAPI.Domain.DTOs;

namespace WorkShopAPI.Infrastructure.AutoMappers
{
    public class FotografiaVehiculoProfile : Profile
    {
        public FotografiaVehiculoProfile()
        {
            CreateMap<FotografiaVehiculoDto, FotografiaVehiculo>()
                .ReverseMap();
        }
    }
}
