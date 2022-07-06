using Microsoft.AspNetCore.Mvc;

namespace CalculadoraWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Resta : Controller
    {
        // GET
        [HttpGet("{a}/{b}")]
        public double Get(double a, double b)
        {
            return a - b;
        }
    }
}