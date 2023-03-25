using Clouds = WeatherApp.BusinessLogic.CurrentWeather.Weather;
using Rain = WeatherApp.BusinessLogic.CurrentWeather.Rain;
using Snow = WeatherApp.BusinessLogic.CurrentWeather.Snow;
using System;
using Weather = WeatherApp.BusinessLogic.CurrentWeather.Weather;
using Wind = WeatherApp.BusinessLogic.CurrentWeather.Wind;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeatherApp.BusinessLogic.WeatherForecast
{
    public class CurrentWeather
    {
        [JsonProperty("dt")]
        public long TimeOfDataForecasted { get; set; }
        [JsonProperty("main")]
        public Main Main { get; set; }
        [JsonProperty("weather")]
        public List<Weather> Weather { get; set; }
        [JsonProperty("clouds")]
        public Clouds Clouds { get; set; }
        [JsonProperty("wind")]
        public Wind Wind { get; set; }
        [JsonProperty("visibility")]
        public int Visibility { get; set; }
        [JsonProperty("pop")]
        public int Precipitation { get; set; }
        [JsonProperty("rain")]
        public Rain Rain { get; set; }
        [JsonProperty("sys")]
        public Twilight Twilight { get; set; }
        [JsonProperty("dt_txt")]
        public string DateTimeOfDataForecasted { get; set; }
    }
}