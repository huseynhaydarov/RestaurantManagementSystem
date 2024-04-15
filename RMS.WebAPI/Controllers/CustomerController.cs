using Microsoft.AspNetCore.Mvc;

namespace RMS.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        [HttpGet]
        public void Test()
        {

        }
    }
}