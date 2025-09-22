using AutoMapper;
using WorkShopAPI.Domain.Context;
using WorkShopAPI.Domain.DTOs;

namespace WorkShopAPI.Infrastructure.AutoMappers
{
    public class RespuestoProfile : Profile
    {
        public RespuestoProfile()
        {
            CreateMap<RepuestoDto, Repuesto>()
                .ReverseMap();
        }
    }
}
