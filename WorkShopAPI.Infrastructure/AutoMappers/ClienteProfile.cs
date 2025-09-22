using AutoMapper;
using WorkShopAPI.Domain.Context;
using WorkShopAPI.Domain.DTOs;

namespace WorkShopAPI.Infrastructure.AutoMappers
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            CreateMap<ClienteDto, Cliente>()
                .ReverseMap();
        }
    }
}
