using System;
using System.Linq;
using System.Windows;
using System.Windows.Media.Imaging;
using WeatherApp.BusinessLogic.CurrentWeather;
using CurrentWeather = WeatherApp.BusinessLogic.CurrentWeather.CurrentWeather;

namespace WeatherApp.Views
{
    public partial class CheckCurrentWeatherWindow : Window
    {
        private static readonly string URL_BASE = "https://openweathermap.org/img/wn/";
        private CurrentWeather currentWeather;

        public CheckCurrentWeatherWindow()
        {
            InitializeComponent();
        }

        public void ConfigureWindow(CurrentWeather currentWeather)
        {
            this.currentWeather = currentWeather;
            ConfigureCurrentWeatherInformation();
            ConfigureWeatherInformation();
            ConfigureMainInformation();
        }

        private void ConfigureCurrentWeatherInformation()
        {
            string name = currentWeather.Name;
            NameLabel.Content = name;
        }

        private void ConfigureWeatherInformation()
        {
            Weather weather = currentWeather.Weather.First();;
            string description = weather.Description;
            description = char.ToUpper(description.First()) + description.Substring(1).ToLower();
            DescriptionLabel.Content = description;
            string icon = weather.Icon;
            ConfigureWeatherIcon(icon);
        }

        private void ConfigureWeatherIcon(string icon)
        {
            string url = string.Format("{0}{1}@2x.png", URL_BASE, icon);
            var bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(url);
            bitmapImage.EndInit();
            WeatherIcon.Source = bitmapImage;
        }

        private void ConfigureMainInformation()
        {
            Main main = currentWeather.Main;
            string temperature = main.Temperature.ToString() + "°";
            TemperatureLabel.Content += temperature;
            string thermalSensation = main.ThermalSensation.ToString() + "°";
            ThermalSensationLabel.Content += thermalSensation;
            string humidityLevel = main.Humidity.ToString() + "%";
            HumidityLevelLabel.Content += humidityLevel;
            string miniumTemperature = main.MiniumTemperature.ToString() + "°";
            MiniumTemperatureLabel.Content += miniumTemperature;
            string maxiumTemperature = main.MaxiumTemperature.ToString() + "°";
            MaxiumTemperatureLabel.Content += maxiumTemperature;
        }

        private void GoBackButtonClick(object sender, RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            Close();
            mainWindow.Show();
        }
    }
}