using Microsoft.AspNetCore.Mvc;
using WorkShopAPI.Application.Common.Interfaces;
using WorkShopAPI.Application.Common.Wrappers;
using WorkShopAPI.Domain.Utils;

namespace WorkShopAPI.RestService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController(ILoginProcess loginProcess,
        IMessageResponse response) : ControllerBase
    {
        private readonly ILoginProcess _loginProcess = loginProcess;
        private readonly IMessageResponse _response = response;

        [HttpGet("LogIn")]
        public async Task<Response> LogIn()
        {
            try
            {
                var token = Request.Headers["Encode"].ToString().IsValid();
                if (string.IsNullOrEmpty(token))
                {
                    return _response.Message(400, MessageGenerics.TokenNoValido, null);
                }
                if (await _loginProcess.Login(token))
                {
                    return _response.Message(200, MessageGenerics.Success, true);
                }
                return _response.Message(400, MessageGenerics.Fail);
            }
            catch (Exception ex)
            {
                return _response.Message(400, ex.Message);
            }
        }
    }
}
