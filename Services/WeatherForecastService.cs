using WeatherApp.BusinessLogic.WeatherForecast;

namespace WeatherApp.Services
{
    public class WeatherForecastService
    {
        public bool Error { get; set; }
        public string Message { get; set; }
        public WeatherForecast WeatherForecast { get; set; }
    }
}