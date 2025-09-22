using AutoMapper;
using WorkShopAPI.Domain.Context;
using WorkShopAPI.Domain.DTOs;

namespace WorkShopAPI.Infrastructure.AutoMappers
{
    public class RepuestoEvaluacionProfile : Profile
    {
        public RepuestoEvaluacionProfile()
        {
            CreateMap<RepuestoEvaluacionDto, RepuestoEvaluacion>()
                .ReverseMap();
        }
    }
}
