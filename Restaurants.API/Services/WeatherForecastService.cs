using Microsoft.AspNetCore.Mvc.Formatters;
using Restaurants.API.Entities;

namespace Restaurants.API.Services
{
    public interface IWeatherForecastService
    {
        public IEnumerable<WeatherForecast> GetForecasts();
    }
    public class WeatherForecastService: IWeatherForecastService
    {
        private static readonly string[] Summaries = new[]
       {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public IEnumerable<WeatherForecast> GetForecasts()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
             .ToArray();
        }

    }
}
