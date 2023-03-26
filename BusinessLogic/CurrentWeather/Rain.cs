using Newtonsoft.Json;

namespace WeatherApp.BusinessLogic.CurrentWeather
{
    public class Rain
    {
        [JsonProperty("1h")]
        public double? RainVolumeForTheLastHour { get; set; }
        [JsonProperty("3h")]
        public double? RainVolumeForTheLastThreeHours { get; set; }
    }
}