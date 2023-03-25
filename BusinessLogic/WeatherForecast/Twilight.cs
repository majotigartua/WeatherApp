using Newtonsoft.Json;

namespace WeatherApp.BusinessLogic.WeatherForecast
{
    public class Twilight
    {
        [JsonProperty("pod")]
        public string PartOfTheDay { get; set; }
    }
}