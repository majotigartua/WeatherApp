using CurrentWeather = WeatherApp.BusinessLogic.WeatherForecast.CurrentWeather;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System;
using System.Linq;
using System.Windows.Media.Imaging;
using WeatherApp.BusinessLogic.WeatherForecast;
using Weather = WeatherApp.BusinessLogic.CurrentWeather.Weather;

namespace WeatherApp.Views
{
    public partial class CheckWeatherForecastWindow : Window
    {
        private static readonly int MINIUM_NUMBER_OF_CURRENT_WEATHERS = 0;
        private static readonly int MAXIUM_NUMBER_OF_CURRENT_WEATHERS = 5;
        private static readonly string URL_BASE = "https://openweathermap.org/img/wn/";
        private Image[] weatherIcons;
        private Label[] descriptionLabels;
        private Label[] miniumTemperatureLabels;
        private Label[] maxiumTemperatureLabels;
        private WeatherForecast weatherForecast;
        private List<CurrentWeather> currentWeathers;

        public CheckWeatherForecastWindow()
        {
            InitializeComponent();
            ConfigureWindowElements();
        }

        private void ConfigureWindowElements()
        {
            weatherIcons = new Image[]
            {
                FirstDayWeatherIcon,
                SecondDayWeatherIcon,
                ThirdDayWeatherIcon,
                FourthDayWeatherIcon,
                FifthDayWeatherIcon
            };
            descriptionLabels = new Label[]
            {
                FirstDayDescriptionLabel,
                SecondDayDescriptionLabel,
                ThirdDayDescriptionLabel,
                FourthDayDescriptionLabel,
                FifthDayDescriptionLabel
            };
            miniumTemperatureLabels = new Label[]
            {
                FirstDayMiniumTemperatureLabel,
                SecondDayMiniumTemperatureLabel,
                ThirdDayMiniumTemperatureLabel,
                FourthDayMiniumTemperatureLabel,
                FifthDayMiniumTemperatureLabel
            };
            maxiumTemperatureLabels = new Label[]
            {
                FirstDayMaxiumTemperatureLabel,
                SecondDayMaxiumTemperatureLabel,
                ThirdDayMaxiumTemperatureLabel,
                FourthDayMaxiumTemperatureLabel,
                FifthDayMaxiumTemperatureLabel
            };
        }

        public void ConfigureWindow(WeatherForecast weatherForecast)
        {
            this.weatherForecast = weatherForecast;
            currentWeathers = weatherForecast.CurrentWeathers;
            ConfigureCurrentWeathersInformation();
            ConfigureCityInformation();
        }

        private void ConfigureCurrentWeathersInformation()
        {
            ConfigureWeatherInformation();
            ConfigureMainInformation();
        }

        private void ConfigureWeatherInformation()
        {
            for (int numberOfCurrentWeather = MINIUM_NUMBER_OF_CURRENT_WEATHERS; numberOfCurrentWeather < MAXIUM_NUMBER_OF_CURRENT_WEATHERS; numberOfCurrentWeather++)
            {
                Weather weather = currentWeathers[numberOfCurrentWeather].Weather.First();
                string icon = weather.Icon;
                weatherIcons[numberOfCurrentWeather].Source = GetWeatherIcon(icon);
                string description = weather.Description;
                description = char.ToUpper(description.First()) + description.Substring(1).ToLower();
                descriptionLabels[numberOfCurrentWeather].Content = description;
            }
        }

        private BitmapImage GetWeatherIcon(string icon)
        {
            string url = string.Format("{0}{1}@2x.png", URL_BASE, icon);
            var bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(url);
            bitmapImage.EndInit();
            return bitmapImage;
        }

        private void ConfigureMainInformation()
        {
            for (int numberOfCurrentWeather = MINIUM_NUMBER_OF_CURRENT_WEATHERS; numberOfCurrentWeather < MAXIUM_NUMBER_OF_CURRENT_WEATHERS; numberOfCurrentWeather++)
            {
                Main main = currentWeathers[numberOfCurrentWeather].Main;
                string miniumTemperature = main.MiniumTemperature.ToString();
                miniumTemperatureLabels[numberOfCurrentWeather].Content += miniumTemperature + "°";
                string maxiumTemperature = main.MaxiumTemperature.ToString();
                maxiumTemperatureLabels[numberOfCurrentWeather].Content += maxiumTemperature + "°";
            }
        }

        private void ConfigureCityInformation()
        {
            City city = weatherForecast.City;
            string name = city.Name;
            NameLabel.Content = name;
        }
    }
}