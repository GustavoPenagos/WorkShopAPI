using AutoMapper;
using WorkShopAPI.Application.Common.Interfaces;
using WorkShopAPI.Application.Common.Interfaces.Repositories.WorkShopDB;
using WorkShopAPI.Application.Common.Wrappers;
using WorkShopAPI.Domain.Context;
using WorkShopAPI.Domain.DTOs;
using WorkShopAPI.Domain.Utils;

namespace WorkShopAPI.Application.Execute.Consultas
{
    public class ConsultProcess(IConsults consults,
        IMessageResponse response,
        IMapper mapper) : IConsultProcess
    {
        private readonly IConsults _consults = consults;
        private readonly IMessageResponse _response = response;
        private readonly IMapper _mapper = mapper;

        public async Task<Response> ConsultCitaServicioAsync()
        {
            var response = await _consults.GetCitaServicioAsync();
            if (response.Count > 0)
            {
                return _response.Message(200, MessageGenerics.Success, _mapper.Map<List<CitaServicioDto>>(response));
            }
            return _response.Message(400, MessageGenerics.NotFound);
        }

        public async Task<Response> ConsultClientsAsync()
        {
            var cliente = await _consults.GetClientesAsync();
            if (cliente.Count > 0)
            {
                return _response.Message(200, MessageGenerics.Success, _mapper.Map<List<ClienteDto>>(cliente));
            }
            return _response.Message(400, MessageGenerics.NotFound);
        }

        public async Task<Response> ConsultMechanicAsync()
        {
            var response = await _consults.GetMecanicoAsync();
            if(response.Count > 0)
            {
                return _response.Message(200, MessageGenerics.Success, _mapper.Map<List<MecanicoDto>>(response));
            }
            return _response.Message(400, MessageGenerics.NotFound);
        }

        public async Task<Response> ConsultPlcasAsync()
        {
            var response = await _consults.GetPlacaAsync();
            return _response.Message(200, MessageGenerics.Success, _mapper.Map<List<VehiculoDto>>(response));
        }

        public async Task<Response> ConsultVehicleAsync(string? placa = "", string? mecanico = "", string? documento = "")
        {
            var response = await _consults.GetVehiculoAsync(placa, mecanico.ToAny<int>(), documento);    
            return _response.Message(200, MessageGenerics.Success, response);
        }

        public async Task<Response> ConsultProductoAsync()
        {
            var response = await _consults.GetProductoAsync();
            return _response.Message(200, MessageGenerics.Success, _mapper.Map<List<RepuestoDto>>(response));
        }
    }
}
