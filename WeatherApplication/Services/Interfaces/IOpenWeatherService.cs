using TodoBlazor.DTOs;

namespace TodoBlazor.Services.Interfaces
{
	public interface IOpenWeatherService
	{
		Task<IEnumerable<LocationDTO>?> GetLocations(LocationSearchDTO locationSearchDTO);
        Task<WeatherDTO> GetWeather(LocationDTO location);

    }
}
