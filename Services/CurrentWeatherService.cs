using CurrentWeather = WeatherApp.BusinessLogic.CurrentWeather.CurrentWeather;

namespace WeatherApp
{
    public class CurrentWeatherService
    {
        public bool Error { get; set; }
        public string Message { get; set; }
        public CurrentWeather CurrentWeather { get; set; }
    }
}