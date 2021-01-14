using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XamarinWeatherApp.Models.OneCallAPI
{
    class DailyWeather
    {
        public DateTimeOffset ConvertedTime { get; set; }

        [JsonProperty("dt")]
        public long Dt { get; set; }

        [JsonProperty("temp")]
        public Temperatures Temperature { get; set; }

        [JsonProperty("wind_speed")]
        public double WindSpeed { get; set; }

        [JsonProperty("weather")]
        public Weather[] Weather { get; set; }


        public DailyWeather()
        {

        }
    }
}
