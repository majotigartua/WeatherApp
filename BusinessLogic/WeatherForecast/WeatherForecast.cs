using System.Collections.Generic;

namespace WeatherApp.BusinessLogic.WeatherForecast
{
    public class WeatherForecast
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public int Counter { get; set; }
        public List<CurrentWeather> CurrentWeathers { get; set; }
        public City City { get; set; }
    }
}