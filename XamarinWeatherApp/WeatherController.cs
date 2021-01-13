using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinWeatherApp.Models;

namespace XamarinWeatherApp
{
    class WeatherController
    {
        private string BaseUrl { get; set; }
        private string ApiKey { get; set; }

        public WeatherData CurrentWeather { get; set; }


        public WeatherController()
        {
            BaseUrl = "https://api.openweathermap.org/data/2.5/";
            ApiKey = "&appid=bd59e85e90494d907927cdec5c884932";
        }


        public async Task GetWeatherByCityAsync(string cityname)
        {
            ApiHandler apiHandler = new ApiHandler();

            string fullUrl = BaseUrl + "weather?q=" + cityname + "&units=metric" + ApiKey;

            CurrentWeather = await apiHandler.FetchDataAsync(fullUrl);
        }
    }
}
