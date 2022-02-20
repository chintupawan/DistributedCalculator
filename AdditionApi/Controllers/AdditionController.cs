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
        public IActionResult Add(double a, double b)
        {
            return Ok(new { result = a+b});
        }
    }
}
