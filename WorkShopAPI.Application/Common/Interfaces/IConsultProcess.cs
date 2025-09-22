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
        Task<Response> ConsultVehicle(string? placa = "", string? mecamoco = "", string? documento = "");
        Task<Response> ConsultPlcas();

    }
}
