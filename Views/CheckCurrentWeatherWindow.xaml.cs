using System.Windows;
using CurrentWeather = WeatherApp.BusinessLogic.CurrentWeather.CurrentWeather;

namespace WeatherApp.Views
{
    public partial class CheckCurrentWeatherWindow : Window
    {
        private CurrentWeather currentWeather;

        public CheckCurrentWeatherWindow()
        {
            InitializeComponent();
        }

        public void ConfigureWindow(CurrentWeather currentWeather)
        {
            this.currentWeather = currentWeather;
        }
    }
}