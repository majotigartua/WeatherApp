using Newtonsoft.Json;
using Coordinates = WeatherApp.BusinessLogic.CurrentWeather.Coordinates;

namespace WeatherApp.BusinessLogic.WeatherForecast
{
    public class City
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("coord")]
        public Coordinates Coordinates{ get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("population")]
        public long Population { get; set; }
        [JsonProperty("timezone")]
        public long TimeZone { get; set; }
        [JsonProperty("sunrise")]
        public long Sunrise { get; set; }
        [JsonProperty("sunset")]
        public long Sunset { get; set; }
    }
}