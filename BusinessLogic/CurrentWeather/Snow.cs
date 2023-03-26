using Newtonsoft.Json;

namespace WeatherApp.BusinessLogic.CurrentWeather
{
    public class Snow
    {
        [JsonProperty("1h")]
        public double? SnowVolumeForTheLastHour { get; set; }
        [JsonProperty("3h")]
        public double? SnowVolumeForTheLastThreeHours { get; set; }
    }
}