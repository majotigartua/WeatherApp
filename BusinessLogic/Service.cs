using CurrentWeather = WeatherApp.BusinessLogic.CurrentWeather.CurrentWeather;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherApp.BusinessLogic.WeatherForecast;
using WeatherApp.Services;

namespace WeatherApp
{
    public static class Service
    {
        private static readonly string URL_BASE = "https://api.openweathermap.org/data/2.5/";
        private static readonly string APP_ID = "b6a174c233aa5179d9b538f646dbef0e";

        public static async Task<CurrentWeatherService> GetCurrentWeather(string city)
        {
            CurrentWeatherService currentWeatherService = new CurrentWeatherService();
            using (var httpClient = new HttpClient())
            {
                HttpRequestMessage httpRequestMessage;
                HttpResponseMessage httpResponseMessage;
                try
                {
                    string url = string.Format("{0}weather?q={1}&appid={2}&lang=es&units=metric", URL_BASE, city, APP_ID);
                    httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, url);
                    httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);
                    if (httpResponseMessage != null)
                    {
                        if (httpResponseMessage.IsSuccessStatusCode)
                        {
                            string content = await httpResponseMessage.Content.ReadAsStringAsync();
                            CurrentWeather currentWeather = JsonConvert.DeserializeObject<CurrentWeather>(content);
                            if (currentWeather != null) 
                            {
                                currentWeatherService.Error = false;
                                currentWeatherService.CurrentWeather = currentWeather;
                            }
                            else
                            {
                                currentWeatherService.Error = true;
                                currentWeatherService.Message = "Could not deserialize the response in JSON. Pleasy, try again.";
                            }
                        }
                        else
                        {
                            currentWeatherService.Error = true;
                            HttpStatusCode httpStatusCode = httpResponseMessage.StatusCode;
                            currentWeatherService.Message = string.Format("Error {0} - {1}", (int)httpStatusCode, httpStatusCode);
                        }
                    }
                    else
                    {
                        currentWeatherService.Error = true;
                        currentWeatherService.Message = "No response could be obtained from the web service. Please, try again.";
                    }
                }
                catch (Exception exception)
                {
                    currentWeatherService.Error = true;
                    currentWeatherService.Message = exception.Message;
                }
            }
            return currentWeatherService;
        }

        public static async Task<WeatherForecastService> GetWeatherForecast(string city)
        {
            WeatherForecastService weatherForecastService = new WeatherForecastService();
            using (var httpClient = new HttpClient())
            {
                HttpRequestMessage httpRequestMessage;
                HttpResponseMessage httpResponseMessage;
                try
                {
                    string url = string.Format("{0}forecast?q={1}&appid={2}&lang=es&units=metric", URL_BASE, city, APP_ID);
                    httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, url);
                    httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);
                    if (httpResponseMessage != null)
                    {
                        if (httpResponseMessage.IsSuccessStatusCode)
                        {
                            string content = await httpResponseMessage.Content.ReadAsStringAsync();
                            WeatherForecast weatherForecast = JsonConvert.DeserializeObject<WeatherForecast>(content);
                            if (weatherForecast != null)
                            {
                                weatherForecastService.Error = false;
                                weatherForecastService.WeatherForecast = weatherForecast;
                            }
                            else
                            {
                                weatherForecastService.Error = true;
                                weatherForecastService.Message = "Could not deserialize the response in JSON. Pleasy, try again.";
                            }
                        }
                        else
                        {
                            weatherForecastService.Error = true;
                            HttpStatusCode httpStatusCode = httpResponseMessage.StatusCode;
                            weatherForecastService.Message = string.Format("Error {0} - {1}", (int)httpStatusCode, httpStatusCode);
                        }
                    }
                    else
                    {
                        weatherForecastService.Error = true;
                        weatherForecastService.Message = "No response could be obtained from the web service. Please, try again.";
                    }
                }
                catch (Exception exception)
                {
                    weatherForecastService.Error = true;
                    weatherForecastService.Message = exception.Message;
                }
            }
            return weatherForecastService;
        }
    }
}