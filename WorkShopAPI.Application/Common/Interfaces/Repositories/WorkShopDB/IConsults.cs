using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShopAPI.Domain.Context;
using WorkShopAPI.Domain.DTOs;
using WorkShopAPI.Domain.DTOs.Response;

namespace WorkShopAPI.Application.Common.Interfaces.Repositories.WorkShopDB
{
    public interface IConsults
    {
        Task<List<PlacaResponse>> GetVehiculoAsync(string? placa = "", int mecanico = 0, string? documento = "");
        Task<List<Vehiculo>> GetPlacaAsync();
        Task<List<Cliente>> GetClientesAsync();
        Task<List<Mecanico>> GetMecanicoAsync();
        Task<List<CitaServicio>> GetCitaServicioAsync();
        Task<List<Repuesto>> GetProductoAsync();

    }
}
