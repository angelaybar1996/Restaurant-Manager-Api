using Microsoft.AspNetCore.Mvc;
using Restaurants.API.Entities;
using Restaurants.API.Services;

namespace Restaurants.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
       
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForecastService _weatherForecastService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,IWeatherForecastService weatherForecastService)
        {
            _logger = logger;
            _weatherForecastService= weatherForecastService;
        }

        [HttpGet]
        [Route("example")]
        public IEnumerable<WeatherForecast> GetForecasts()
        {
            var result = _weatherForecastService.GetForecasts();
            return result;
        }


    }
}
