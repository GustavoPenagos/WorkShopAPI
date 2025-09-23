using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using WorkShopAPI.Application.Common.Interfaces;
using WorkShopAPI.Application.Common.Interfaces.Repositories.WorkShopDB;
using WorkShopAPI.Application.Common.Wrappers;
using WorkShopAPI.Domain.Utils;

namespace WorkShopAPI.RestService.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ConsultController (IConsultProcess consults,
        IMessageResponse response) : ControllerBase
    {
        private readonly IConsultProcess _conults = consults;
        private readonly IMessageResponse _response = response;

        [HttpGet("vehiculos")]
        public async Task<Response> GetVhiculos(string placa)
        {
            Response response = new();
            try
            {
                if (string.IsNullOrEmpty(placa))
                {
                    return _response.Message(400, MessageGenerics.NotFound);
                }
                response = await _conults.ConsultVehicleAsync(placa);
                
                
            }
            catch (Exception ex)
            {
                return _response.Message(400, MessageGenerics.Failed, ex.Message);
            }
            return response;
        }

        /// <summary>
        /// GetPlaca
        /// </summary>
        /// <returns>Modelo de response con los datos del vehiculo</returns>
        [HttpGet("GetPlaca")]
        public async Task<Response> GetPlaca()
        {
            Response response;
            try
            {
                response = await _conults.ConsultPlcasAsync();
            }
            catch (Exception ex)
            {
                return _response.Message(400, MessageGenerics.Failed, ex.Message);
            }
            return response;
        }

        /// <summary>
        /// GetCliente
        /// </summary>
        /// <returns>Modelo de response con los datos del cliente</returns>
        [HttpGet("GetCliente")]
        public async Task<Response> GetCliente()
        {
            Response response;
            try
            {
                response = await _conults.ConsultClientsAsync();
            }
            catch (Exception ex)
            {
                return _response.Message(400, ex.Message);                
            }
            return response;
        }

        /// <summary>
        /// GetMecanico
        /// </summary>
        /// <returns>Modelo de response con los datos del mecanico</returns>
        [HttpGet("GetMecanico")]
        public async Task<Response> GetMecanico()
        {
            Response response;
            try
            {
                response = await _conults.ConsultMechanicAsync();
            }
            catch (Exception ex)
            {
                return _response.Message(400, ex.Message);
            }
            return response;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Modelo de response con los datos del CitaServico</returns>
        [HttpGet("GetCitaServicio")]
        public async Task<Response> GetCitaServicio()
        {
            Response response;
            try
            {
                response = await _conults.ConsultCitaServicioAsync();
            }
            catch (Exception ex)
            {
                return _response.Message(400, ex.Message);
            }
            return response;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Modelo de response con los datos del CitaServico</returns>
        [HttpGet("GetProducto")]
        public async Task<Response> GetProducto()
        {
            Response response;
            try
            {
                response = await _conults.ConsultProductoAsync();
            }
            catch (Exception ex)
            {
                return _response.Message(400, ex.Message);
            }
            return response;
        }
    }
}
