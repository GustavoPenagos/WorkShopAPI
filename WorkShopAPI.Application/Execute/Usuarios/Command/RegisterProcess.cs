using AutoMapper;
using WorkShopAPI.Application.Common.Interfaces;
using WorkShopAPI.Application.Common.Interfaces.Repositories.WorkShopDB;
using WorkShopAPI.Application.Common.Wrappers;
using WorkShopAPI.Domain.Context;
using WorkShopAPI.Domain.DTOs;
using WorkShopAPI.Domain.Utils;

namespace WorkShopAPI.Application.Execute.Usuarios.Command
{
    public class RegisterProcess(IRegisterClient register,
        IMessageResponse response,
        IMapper mapper) : IRegisterProcess
    {
        private readonly IMapper _mapper = mapper;
        private readonly IMessageResponse _response = response;
        private readonly IRegisterClient _register = register;

        public async Task<Response> RegisterClientAsync(ClienteDto clienteDto, string token)
        {
            clienteDto.Usuarios.First().Contrasenia = token;
            if(!await _register.RegisterAsync(_mapper.Map<Cliente>(clienteDto)))
            {
                return _response.Message(400, MessageGenerics.NotFound);
            }
            return _response.Message(200, MessageGenerics.Success, true);
        }

        public async Task<Response> RegisterAsync<T>(object dataDto)
        {
            if (!await _register.RegisterAsync(_mapper.Map<T>(dataDto)))
            {
                return _response.Message(400, MessageGenerics.NotFound);
            }
            return _response.Message(200, MessageGenerics.Success, true);
        }

        public async Task<Response> RegisterValoracionAsync(RequestEvaluacion requestEvaluacion)
        {
           
            if (!await _register.RegisterAsync(_mapper.Map<Evaluacion>(requestEvaluacion.Evaluacion)))
            {
                return _response.Message(400, MessageGenerics.NotFound);
            }
            if (!await _register.RegisterAsync(_mapper.Map<RepuestoEvaluacion>(requestEvaluacion.RuestoEvaluacion)))
            {
                return _response.Message(400, MessageGenerics.NotFound);
            }
            if (!await _register.RegisterAsync(_mapper.Map<FotografiaVehiculo>(requestEvaluacion.FotografiaVehiculo)))
            {
                return _response.Message(400, MessageGenerics.NotFound);
            }

            return _response.Message(200, MessageGenerics.Success, true);
        }
    }
}
