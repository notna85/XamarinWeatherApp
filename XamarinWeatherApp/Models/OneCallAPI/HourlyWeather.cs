using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XamarinWeatherApp.Models.OneCallAPI
{
    class HourlyWeather
    {
        public DateTimeOffset ConvertedTime { get; set; }

        [JsonProperty("dt")]
        public long Dt { get; set; }

        [JsonProperty("temp")]
        public double Temperature { get; set; }

        [JsonProperty("wind_speed")]
        public double WindSpeed { get; set; }

        [JsonProperty("weather")]
        public Weather[] Weather { get; set; }


        public HourlyWeather()
        {

        }
    }
}
