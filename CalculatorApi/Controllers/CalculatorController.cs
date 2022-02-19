using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {

        [Route("add")]
        [HttpGet]
        public async Task<double> Add(double a, double b)
        {
            string url = $"http://localhost:3500/v1.0/invoke/addapp/method";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            var result = await client.GetStringAsync($"/add?a={a}&b={b}");

            return Double.Parse(result);
        }

        [Route("subtract")]
        [HttpGet]
        public async Task<double> Subtract(double a, double b)
        {
            string url = $"http://localhost:3500/v1.0/invoke/subtractapp/method";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            var result = await client.GetStringAsync($"/subtract?a={a}&b={b}");

            return Double.Parse(result);
        }
    }
}
