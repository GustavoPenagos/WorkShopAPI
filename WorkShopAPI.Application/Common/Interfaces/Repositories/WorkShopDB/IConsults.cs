using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShopAPI.Domain.Context;
using WorkShopAPI.Domain.DTOs.Response;

namespace WorkShopAPI.Application.Common.Interfaces.Repositories.WorkShopDB
{
    public interface IConsults
    {
        Task<List<PlacaResponse>> GetVehiculo(string? placa = "", int mecanico = 0, string? documento = "");
        Task<List<string>> GetPlaca();
    }
}
