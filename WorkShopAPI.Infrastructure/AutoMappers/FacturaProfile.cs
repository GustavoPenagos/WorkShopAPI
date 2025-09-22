using AutoMapper;
using WorkShopAPI.Domain.Context;
using WorkShopAPI.Domain.DTOs;

namespace WorkShopAPI.Infrastructure.AutoMappers
{
    public class FacturaProfile : Profile
    {
        public FacturaProfile()
        {
            CreateMap<FacturaDto, Factura>()
                .ReverseMap();
        }
    }
}
