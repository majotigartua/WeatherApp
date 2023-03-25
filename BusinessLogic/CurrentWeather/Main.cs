using Newtonsoft.Json;

namespace WeatherApp.BusinessLogic.CurrentWeather
{
    public class Main
    {
        [JsonProperty("temp")]
        public double Temperature { get; set; }
        [JsonProperty("feels_like")]
        public double ThermalSensation { get; set; }
        [JsonProperty("temp_min")]
        public double MiniumTemperature { get; set; }
        [JsonProperty("temp_max")]
        public double MaxiumTemperature { get; set; }
        [JsonProperty("pressure")]
        public int Pressure { get; set; }
        [JsonProperty("humidity")]
        public int Humidity { get; set; }
    }
}