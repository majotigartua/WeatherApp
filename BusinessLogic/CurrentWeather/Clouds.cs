using Newtonsoft.Json;

namespace WeatherApp.BusinessLogic.CurrentWeather
{
    public class Clouds
    {
        [JsonProperty("all")]
        public int Cloudiness { get; set; }
    }
}