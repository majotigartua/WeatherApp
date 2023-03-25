using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WeatherApp.BusinessLogic.CurrentWeather
{
    public class CurrentWeather
    {
        [JsonProperty("coord")]
        public Coordinates Coordinates { get; set; }
        [JsonProperty("weather")]
        public List<Weather> Weather { get; set; }
        [JsonProperty("base")]
        public string Base { get; set; }
        [JsonProperty("main")]
        public Main Main { get; set; }
        [JsonProperty("visibility")]
        public int Visibility { get; set; }
        [JsonProperty("wind")]
        public Wind Wind { get; set; }
        [JsonProperty("rain")]
        public Rain Rain { get; set; }
        [JsonProperty("snow")]
        public Snow Snow { get; set; }
        [JsonProperty("clouds")]
        public Clouds Clouds { get; set; }
        [JsonProperty("dt")]
        public int TimeOfDataCalculation { get; set; }
        [JsonProperty("sys")]
        public Twilight Twilight { get; set; }
        [JsonProperty("timezone")]
        public int TimeZone { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("cod")]
        public int Code { get; set; }
    }
}