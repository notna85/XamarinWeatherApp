using System;
using System.Collections.Generic;
using System.Text;
using XamarinWeatherApp.Models;

namespace XamarinWeatherApp
{
    class WeatherController
    {
        public string BaseUrl { get; set; }
        public string ApiKey { get; set; }

        public WeatherController()
        {
            BaseUrl = "https://api.openweathermap.org/data/2.5/";
            ApiKey = "&appid=";
        }

        public async void GetWeatherByCity(string cityname)
        {
            ApiHandler apiHandler = new ApiHandler();

            string fullUrl = BaseUrl + "weather?q=" + cityname + ApiKey;

            WeatherData weather = await apiHandler.FetchDataAsync(fullUrl);


        }
    }
}
