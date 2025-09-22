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
                response = await _conults.ConsultVehicle(placa);
                
                
            }
            catch (Exception ex)
            {
                return _response.Message(400, MessageGenerics.Fail, ex.Message);
            }
            return response;
        }

        [HttpGet("GetPlaca")]
        public async Task<Response> GetPlaca()
        {
            Response response = new();
            try
            {
                response = await _conults.ConsultPlcas();
            }
            catch (Exception ex)
            {
                return _response.Message(400, MessageGenerics.Fail, ex.Message);
            }
            return response;
        }
    }
}
