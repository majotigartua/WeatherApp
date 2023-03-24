using CurrentWeather = WeatherApp.BusinessLogic.CurrentWeather.CurrentWeather;
using System.Windows;
using WeatherApp.Services;
using WeatherApp.BusinessLogic.WeatherForecast;
using System;
using WeatherApp.Views;

namespace WeatherApp
{
    public partial class MainWindow : Window
    {
        private CurrentWeather currentWeather;
        private WeatherForecast weatherForecast;

        public MainWindow()
        {
            InitializeComponent();
            ConfigureView();
        }

        private void ConfigureView()
        {
            CityTextBox.Focus();
        }

        private async void CheckCurrentWeatherButtonClick(object sender, RoutedEventArgs e)
        {
            if (!CheckEmptyFields())
            {
                string city = CityTextBox.Text.ToLower();
                CurrentWeatherService currentWeatherService = await Service.GetCurrentWeather(city);
                if (!currentWeatherService.Error)
                {
                    currentWeather = currentWeatherService.CurrentWeather;
                    if (currentWeather != null)
                    {
                        GoToCheckCurrentWeather();
                    }
                }
                else
                {
                    MessageBox.Show(currentWeatherService.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("No se puede dejar ningún campo vacío.", "ADVERTENCIA", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void GoToCheckCurrentWeather()
        {
            var checkCurrentWeatherWindow = new CheckCurrentWeatherWindow();
            checkCurrentWeatherWindow.ConfigureWindow(currentWeather);
            Close();
            checkCurrentWeatherWindow.Show();
        }

        private bool CheckEmptyFields()
        {
            return string.IsNullOrEmpty(CityTextBox.Text);
        }

        private async void CheckWeatherForecastButtonClick(object sender, RoutedEventArgs e)
        {
            if (!CheckEmptyFields())
            {
                string city = CityTextBox.Text.ToLower();
                WeatherForecastService weatherForecastService = await Service.GetWeatherForecast(city);
                if (!weatherForecastService.Error)
                {
                    weatherForecast = weatherForecastService.WeatherForecast;
                    if (weatherForecast != null)
                    {
                        GoToCheckWeatherForecast();
                    }
                }
                else
                {
                    MessageBox.Show(weatherForecastService.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("No se puede dejar ningún campo vacío.", "ADVERTENCIA", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void GoToCheckWeatherForecast()
        {
            var checkWeatherForecast = new CheckWeatherForecastWindow();
            checkWeatherForecast.ConfigureWindow(weatherForecast);
            Close();
            checkWeatherForecast.Show();
        }
    }
}