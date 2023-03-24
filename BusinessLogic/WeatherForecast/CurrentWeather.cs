using Clouds = WeatherApp.BusinessLogic.CurrentWeather.Weather;
using Rain = WeatherApp.BusinessLogic.CurrentWeather.Rain;
using Snow = WeatherApp.BusinessLogic.CurrentWeather.Snow;
using System;
using Weather = WeatherApp.BusinessLogic.CurrentWeather.Weather;
using Wind = WeatherApp.BusinessLogic.CurrentWeather.Wind;

namespace WeatherApp.BusinessLogic.WeatherForecast
{
    public class CurrentWeather
    {
        public DateTime TimeOfDataForecasted { get; set; }
        public Main Main { get; set; }
        public Weather Weather { get; set; }
        public Clouds Clouds { get; set; }
        public Wind Wind { get; set; }
        public int Visibility { get; set; }
        public int Precipitation { get; set; }
        public Rain Rain { get; set; }
        public Snow Snow { get; set; }
        public Twilight Twilight { get; set; }
        public string DateTimeOfDataForecasted { get; set; }
    }
}