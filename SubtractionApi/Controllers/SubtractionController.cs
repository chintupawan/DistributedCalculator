using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SubtractionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubtractionController : ControllerBase
    {

        [Route("subtract")]
        [HttpGet]
        public double Subtract(double a, double b)
            { return a - b; }
    }
}
