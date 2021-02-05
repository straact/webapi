using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/home")]
    public class Home : Controller
    {
        [HttpGet]
        public string Index()
        {
            return "Hello from API";
        }
    }
}