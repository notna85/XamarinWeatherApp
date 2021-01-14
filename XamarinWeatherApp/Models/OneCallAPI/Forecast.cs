using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XamarinWeatherApp.Models.OneCallAPI
{
    class Forecast
    {
        public string City { get; set; }

        [JsonProperty("coord")]
        public Coord Coord { get; set; }

        [JsonProperty("timezone")]
        public string TimeZone { get; set; }

        [JsonProperty("current")]
        public CurrentWeather Current { get; set; }

        [JsonProperty("hourly")]
        public HourlyWeather[] Hourly { get; set; }

        [JsonProperty("daily")]
        public DailyWeather[] Daily { get; set; }

        public Forecast()
        {

        }
    }
}
