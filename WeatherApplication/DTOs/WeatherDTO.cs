using TodoBlazor.DTOs.OpenWeather.Current;
using TodoBlazor.DTOs.OpenWeather.Forecast;

namespace TodoBlazor.DTOs
{
    public class WeatherDTO
    {
        public LocationDTO Location { get; set; }

        public CurrentWeatherDTO CurrentWeather { get; set; }

        public WeatherForecastDTO WeatherForecast { get; set; }
    }
}
