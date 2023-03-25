using Newtonsoft.Json;

namespace WeatherApp.BusinessLogic.CurrentWeather
{
    public class Wind
    {
        [JsonProperty("speed")]
        public double Speed { get; set; }
        [JsonProperty("deg")]
        public int Degrees { get; set; }
        [JsonProperty("gust")]
        public double Gust { get; set; }
    }
}