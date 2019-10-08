using Microsoft.AspNetCore.Mvc;

namespace WebApiStarter2.Controller
{
    [ApiController]
    [Route("[controller]")]

    public class GreatController: ControllerBase
    {
        [HttpGet]
        public string Get(){
            return "Hello from Great!";
        }
    }
}