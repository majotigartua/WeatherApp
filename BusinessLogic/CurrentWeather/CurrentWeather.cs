using System;
using System.Collections.Generic;

namespace WeatherApp.BusinessLogic.CurrentWeather
{
    public class CurrentWeather
    {
        public Coordinates Coordinates { get; set; }
        public List<Weather> Weather { get; set; }
        public string Base { get; set; }
        public Main Main { get; set; }
        public int Visibility { get; set; }
        public Wind Wind { get; set; }
        public Rain Rain { get; set; }
        public Snow Snow { get; set; }
        public Clouds Clouds { get; set; }
        public DateTime TimeOfDataCalculation { get; set; }
        public Twilight Twilight { get; set; }
        public int TimeZone { get; set; }
        public long Id { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }
    }
}