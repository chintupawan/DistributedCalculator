using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdditionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdditionController : ControllerBase
    {

        [Route("add")]
        [HttpGet]
        public double Add(double a, double b)
        {
            return a+b;
        }
    }
}
