using Microsoft.AspNetCore.Mvc;
using WorkShopAPI.Application.Common.Interfaces;
using WorkShopAPI.Application.Common.Wrappers;
using WorkShopAPI.Domain.Context;
using WorkShopAPI.Domain.DTOs;
using WorkShopAPI.Domain.Utils;

namespace WorkShopAPI.RestService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegistryController(IRegisterProcess register,
        IMessageResponse response) : ControllerBase
    {
        private readonly IRegisterProcess _register = register;
        private readonly IMessageResponse _response = response;

        [HttpPost("RegistryClient")]
        public async Task<Response> RegistryClient(ClienteDto cliente)
        {
            try
            {
                var token = Request.Headers["Encode"].ToString();
                if (!token.IsValid())
                {
                    return _response.Message(400, MessageGenerics.TokenNoValido);
                }
                var response = await _register.RegisterClientAsync(cliente, token);
                return response;
            }
            catch (Exception ex)
            {
                return _response.Message(400, ex.Message);
            }
        }

        [HttpPost("RegistryMechanic")]
        public async Task<Response> RegistryMechanic(MecanicoDto mecanicoDto)
        {
            try
            {
                var response = await _register.RegisterAsync<Mecanico>(mecanicoDto);
                return response;
            }
            catch (Exception ex)
            {
                return _response.Message(400, ex.Message);
            }

        }

        [HttpPost("RegistryDate")]
        public async Task<Response> RegistryData(CitaServicioDto citaServicioDto)
        {
            try
            {
                var response = await _register.RegisterAsync<CitaServicio>(citaServicioDto);
                return response;
            }
            catch (Exception ex)
            {
                return _response.Message(400, ex.Message);
            }

        }

        [HttpPost("RegistryEvaluation")]
        public async Task<Response> RegistryEvaluation(EvaluacionDto evaluacionDto)
        {
            try
            {
                var response = await _register.RegisterAsync<Evaluacion>(evaluacionDto);
                return response;
            }
            catch (Exception ex)
            {
                return _response.Message(400, ex.Message);
            }

        }

        [HttpPost("RegistryRepuesto")]
        public async Task<Response> RegistryRepuesto(RepuestoDto repuestoDto)
        {
            try
            {
                var response = await _register.RegisterAsync<Repuesto>(repuestoDto);
                return response;
            }
            catch (Exception ex)
            {
                return _response.Message(400, ex.Message);
            }

        }

        [HttpPost("RegistryValoracion")]
        public async Task<Response> RegistryValoracion(RequestEvaluacion requestEvaluacion)
        {
            try
            {
                var response = await _register.RegisterValoracionAsync(requestEvaluacion);
                return response;
            }
            catch (Exception ex)
            {
                return _response.Message(400, ex.Message);
            }

        }

    }
}
