using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShopAPI.Application.Common.Interfaces;
using WorkShopAPI.Application.Common.Interfaces.Repositories.WorkShopDB;
using WorkShopAPI.Application.Common.Wrappers;
using WorkShopAPI.Domain.DTOs;
using WorkShopAPI.Domain.DTOs.Response;
using WorkShopAPI.Domain.Utils;

namespace WorkShopAPI.Application.Execute.Consultas
{
    public class ConsultProcess(IConsults consults,
        IMessageResponse response) : IConsultProcess
    {
        private readonly IConsults _consults = consults;
        private readonly IMessageResponse _response = response;

        public async Task<Response> ConsultPlcas()
        {
            var response = await _consults.GetPlaca();
            return _response.Message(200, MessageGenerics.Success, response);
        }

        public async Task<Response> ConsultVehicle(string? placa = "", string? mecanico = "", string? documento = "")
        {
            var response = await _consults.GetVehiculo(placa, mecanico.ToAny<int>(), documento);    
            return _response.Message(200, MessageGenerics.Success, response);
        }
    }
}
