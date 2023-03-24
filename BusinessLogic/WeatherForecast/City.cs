namespace WeatherApp.BusinessLogic.WeatherForecast
{
    public class City
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public BusinessLogic.CurrentWeather.Coordinates Coordinates { get; set; }
        public string Country { get; set; }
        public int Population { get; set; }
        public int TimeZone { get; set; }
        public long Sunrise { get; set; }
        public long Sunset { get; set; }
    }
}