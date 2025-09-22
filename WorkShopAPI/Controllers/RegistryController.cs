using Microsoft.AspNetCore.Mvc;
using WorkShopAPI.Application.Common.Interfaces;
using WorkShopAPI.Application.Common.Wrappers;
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
        [HttpPost("Registry")]
        public async Task<Response> Registry(ClienteBase cliente)
        {
            try
            {
                var token = Request.Headers["Encode"].ToString().IsValid();
                if (string.IsNullOrEmpty(token))
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
    }
}
