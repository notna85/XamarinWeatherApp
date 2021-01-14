using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinWeatherApp.Models;
using XamarinWeatherApp.Models.OneCallAPI;

namespace XamarinWeatherApp
{
    class WeatherController
    {
        private string BaseUrl { get; set; }
        public string OneCallApiUrl { get; set; }
        private string ApiKey { get; set; }

        public Forecast Forecast { get; set; }


        public WeatherController()
        {
            BaseUrl = "https://api.openweathermap.org/data/2.5/";
            OneCallApiUrl = "https://api.openweathermap.org/data/2.5/onecall?lat=";
            ApiKey = "bd59e85e90494d907927cdec5c884932";
        }


        public async Task GetWeatherByCityAsync(string cityname)
        {
            ApiHandler apiHandler = new ApiHandler();

            //Calls API to get lon & lat from the supplied cityname
            string fullUrl = BaseUrl + "weather?q=" + cityname + "&units=metric" + "&appid=" + ApiKey;
            Forecast = await apiHandler.FetchDataAsync(fullUrl);
            
            if (Forecast != null)
            {
                //Calls API again with the returned lon & lat values to get the actual weatherdata
                fullUrl = OneCallApiUrl + Forecast.Coord.Lat + "&lon=" + Forecast.Coord.Lon + "&exclude=hourly,alerts,minutely" + "&units=metric" + "&appid=" + ApiKey;
                Forecast = await apiHandler.FetchDataAsync(fullUrl);

                Forecast.Current.ConvertedTime = DateTimeOffset.FromUnixTimeSeconds(Forecast.Current.Dt);
                Forecast.City = cityname;
                Forecast.Current.Weather[0].DisplayIcon = "http://openweathermap.org/img/wn/" + Forecast.Current.Weather[0].Icon + "@2x.png";
            }


        }
    }
}
