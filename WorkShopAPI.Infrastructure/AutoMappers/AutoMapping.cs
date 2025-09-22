using AutoMapper;
using WorkShopAPI.Domain.Context;
using WorkShopAPI.Domain.DTOs;

namespace WorkShopAPI.Infrastructure.AutoMappers
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<CitaServicioDto, CitaServicio>()
                .ReverseMap();
            CreateMap<ClienteDto, Cliente>()
                .ReverseMap();
            CreateMap<EvaluacionDto, Evaluacion>()
                .ReverseMap();
            CreateMap<FacturaDto, Factura>()
                .ReverseMap();
            CreateMap<FotografiaVehiculoDto, FotografiaVehiculo>()
                .ReverseMap();
            CreateMap<MecanicoDto, Mecanico>()
                .ReverseMap();
            CreateMap<RepuestoEvaluacionDto, RepuestoEvaluacion>()
                .ReverseMap();
            CreateMap<RepuestoDto, Repuesto>()
                .ReverseMap();
            CreateMap<UsuarioDto, Usuario>()
               .ReverseMap();
            CreateMap<VehiculoDto, Vehiculo>()
                .ReverseMap();
        }
    }
}
