using Dapr.Client;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger logger;

        public CalculatorController()
        {
            //this.logger = logger;
        }

        [Route("add")]
        [HttpGet]
        public async Task<double> Add(double a, double b)
        {
            string? addApi = Environment.GetEnvironmentVariable("AddApi");
            string url = $"{addApi}";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            //  logger.LogInformation($"********Service URL is {addApi}");
            var result = await client.GetStringAsync($"/api/Addition/add?a={a}&b={b}");

            return Double.Parse(result);
        }

        [Route("addDapr")]
        [HttpGet]
        public async Task<double> AddDapr(double a, double b)
        {
            var client = DaprClient.CreateInvokeHttpClient(appId: "add-api");
            //string? addApi = Environment.GetEnvironmentVariable("AddApi");
            //string url = $"{addApi}";
            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri(url);
            //  logger.LogInformation($"********Service URL is {addApi}");
            var result = await client.GetStringAsync($"/api/Addition/add?a={a}&b={b}");

            return double.Parse(result);
        }

        [Route("subtract")]
        [HttpGet]
        public async Task<double> Subtract(double a, double b)
        {
            string? subApi = Environment.GetEnvironmentVariable("SubApi");
            string url = $"{subApi}";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            var result = await client.GetStringAsync($"/api/Subtraction/subtract?a={a}&b={b}");

            return Double.Parse(result);
        }
    }
}
