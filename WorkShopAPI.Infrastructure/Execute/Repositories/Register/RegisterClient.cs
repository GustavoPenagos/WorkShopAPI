using AutoMapper;
using Azure.Core;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using WorkShopAPI.Application.Common.Interfaces.Repositories.WorkShopDB;
using WorkShopAPI.Domain.Context;
using WorkShopAPI.Domain.DTOs;

namespace WorkShopAPI.Infrastructure.Execute.Repositories.Register
{
    public class RegisterClient(WorskShopContext context,
        IMapper mapper) : IRegisterClient
    {
        private readonly WorskShopContext _context = context;
        private readonly IMapper _mapper = mapper;

        public async Task<ClienteBase> RegisterDBAsync(Cliente cliente,
            Usuario usuario,
            CitaServicio citaServicio,
            Vehiculo vehiculo,
            string token)
        {
            try
            {
                _context.Add(cliente);
                //await _context.SaveChangesAsync();

                usuario.ClienteId = cliente.ClienteId;
                usuario.Contrasenia = token;
                _context.Add(usuario);
                //await _context.SaveChangesAsync();

                //_context.Add(mecanico);
                //await _context.SaveChangesAsync();

                vehiculo.ClienteId = cliente.ClienteId;
                _context.Add(vehiculo);
                //await _context.SaveChangesAsync();

                //citaServicio.MecanicoId = mecanico.MecanicoId;
                citaServicio.VehiculoId = vehiculo.VehiculoId;
                _context.Add(citaServicio);
                await _context.SaveChangesAsync();

                //evaluacion.CitaId = citaServicio.CitaId;
                //_context.Add(evaluacion);
                //await _context.SaveChangesAsync();

                //_context.Add(repuesto);
                //await _context.SaveChangesAsync();

                //repuestoEvaluacion.RepuestoId = repuesto.RepuestoId;
                //repuestoEvaluacion.EvaluacionId = evaluacion.EvaluacionId;
                //_context.Add(repuestoEvaluacion);
                //await _context.SaveChangesAsync();

                //fotografiaVehiculo.VehiculoId = vehiculo.VehiculoId;
                //_context.Add(fotografiaVehiculo);
                //await _context.SaveChangesAsync();

                //factura.EvaluacionId = evaluacion.EvaluacionId;
                //_context.Add(factura);
                //await _context.SaveChangesAsync();

                return ConvedrtToBase(cliente,
                    usuario,
                    vehiculo,
                    citaServicio); 

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private ClienteBase ConvedrtToBase(Cliente cliente, Usuario usuario, Vehiculo vehiculo, CitaServicio citaServicio)
        => new()
        {
            Cliente = _mapper.Map<ClienteDto>(cliente),
            CitaServicio = _mapper.Map<CitaServicioDto>(citaServicio),
            Usuario = _mapper.Map<UsuarioDto>(usuario),
            Vehiculo = _mapper.Map<VehiculoDto>(vehiculo),
        };
    }
}
