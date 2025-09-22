using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using WorkShopAPI.Application.Common.Interfaces.Repositories.WorkShopDB;
using WorkShopAPI.Domain.Context;
using WorkShopAPI.Domain.DTOs.Response;

namespace WorkShopAPI.Infrastructure.Execute.Repositories.Consult
{
    public class Consults(WorskShopContext context) : IConsults
    {
        private readonly WorskShopContext _context = context;

        public async Task<List<string>> GetPlaca()
        {
            List<string> response = [];
            try
            {
                response = await _context.Vehiculos.Select(i => i.Placa).ToListAsync();
            }
            catch (Exception ex)
            {
                throw  new Exception(ex.Message);
            }
            return response;
        }

        public async Task<List<PlacaResponse>> GetVehiculo(string? placa = "", int mecanico = 0, string? documento = "")
        {
            List<PlacaResponse> vehiculo = [];
            try
            {
                vehiculo = await (from c in _context.Clientes
                                join v in _context.Vehiculos on c.ClienteId equals v.ClienteId
                                join m in _context.Mecanicos on v.VehiculoId equals m.VehiculoId
                                where c.Documento.Equals(documento) || v.Placa.Equals(placa) || m.MecanicoId == mecanico
                                select (new PlacaResponse
                                {
                                    NroDucomento = c.Documento,
                                    NombreCliente = $"{c.Nombres} {c.Apellidos}",
                                    PlacaVihiculo = v.Placa,
                                    CodigoMecanico = m.MecanicoId,
                                    NombreMecanico = $"{m.Nombre} {m.Apellidos}"

                                })).ToListAsync();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return vehiculo;
        }
    }
}
