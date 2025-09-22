using AutoMapper;
using WorkShopAPI.Domain.Context;
using WorkShopAPI.Domain.DTOs;

namespace WorkShopAPI.Infrastructure.AutoMappers
{
    public class MecanicoProfile : Profile
    {
        public MecanicoProfile()
        {
            CreateMap<MecanicoDto, Mecanico>()
                .ReverseMap();
        }
    }
}
