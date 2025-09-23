using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShopAPI.Application.Common.Wrappers;

namespace WorkShopAPI.Application.Common.Interfaces
{
    public interface IConsultProcess
    {
        Task<Response> ConsultVehicleAsync(string? placa = "", string? mecamoco = "", string? documento = "");
        Task<Response> ConsultPlcasAsync();
        Task<Response> ConsultClientsAsync();
        Task<Response> ConsultMechanicAsync();
        Task<Response> ConsultCitaServicioAsync();
        Task<Response> ConsultProductoAsync();

    }
}
