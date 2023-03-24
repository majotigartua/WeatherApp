using System.Windows;
using WeatherApp.BusinessLogic.WeatherForecast;

namespace WeatherApp.Views
{
    public partial class CheckWeatherForecastWindow : Window
    {
        public WeatherForecast weatherForecast;

        public CheckWeatherForecastWindow()
        {
            InitializeComponent();
        }

        public void ConfigureWindow(WeatherForecast weatherForecast)
        {
            this.weatherForecast = weatherForecast;
        }
    }
}
