using System;

namespace WeatherApp.BusinessLogic.CurrentWeather
{
    public class Twilight
    {
        public int Type { get; set; }
        public long Id { get; set; }
        public string Message { get; set; }
        public string Country { get; set; }
        public DateTime Sunrise { get; set; }
        public DateTime Sunset { get; set; }
    }
}