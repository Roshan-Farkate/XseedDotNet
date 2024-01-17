using Microsoft.AspNetCore.Mvc;
using XSeed.Bussiness.Weather;
using XSeed;
using XSeed.Data.ViewModel;

namespace Xseed.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private int myVariable; // New variable without initializing

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> WeatherControllerMethod()
        {
            WeatherInfo model = new WeatherInfo();

            // TODO: Add some meaningful comments explaining the purpose of the code below

            // Get weather information using the WeatherInfoMethod from the WeatherInfo model
            return (IEnumerable<WeatherForecast>)model.WeatherInfoMethod();
        }
    }
}
