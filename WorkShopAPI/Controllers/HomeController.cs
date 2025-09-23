using Microsoft.AspNetCore.Mvc;
using WorkShopAPI.Domain.Utils;

namespace WorkShopAPI.RestService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index(string item)
        {
            var response = item.Encrypt();
            return Ok(response);
        }
    }
}
