using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShopAPI.Domain.Context;
using WorkShopAPI.Domain.DTOs;

namespace WorkShopAPI.Infrastructure.AutoMappers
{
    public class VehiculoProfile : Profile
    {
        public VehiculoProfile()
        {
            CreateMap<VehiculoDto, Vehiculo>()
                .ReverseMap();
        }
    }
}
