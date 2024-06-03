using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VueDotnetExample.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorld : ControllerBase
    {
        [HttpGet("hello")]
        public string GetHelloWorld()
        {
            return "Hello, World!";
        }
    }
}
