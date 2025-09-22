using AutoMapper;
using WorkShopAPI.Domain.Context;
using WorkShopAPI.Domain.DTOs;

namespace WorkShopAPI.Infrastructure.AutoMappers
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<UsuarioDto, Usuario>()
                .ReverseMap();
        }
    }
}
