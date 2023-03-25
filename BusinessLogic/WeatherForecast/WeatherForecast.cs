using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeatherApp.BusinessLogic.WeatherForecast
{
    public class WeatherForecast
    {
        [JsonProperty("cod")]
        public int Code { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("cnt")]
        public long Counter { get; set; }
        [JsonProperty("list")]
        public List<CurrentWeather> CurrentWeathers { get; set; }
        [JsonProperty("city")]
        public City City { get; set; }
    }
}