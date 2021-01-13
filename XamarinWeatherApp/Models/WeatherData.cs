using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XamarinWeatherApp.Models
{
    public class WeatherData
    {
        [JsonIgnore]
        public Coord Coord { get; set; }

        [JsonProperty("weather")]
        public Weather[] Weather { get; set; }

        [JsonIgnore]
        public string Base { get; set; }

        [JsonProperty("main")]
        public Main Main { get; set; }

        [JsonIgnore]
        public long Visibility { get; set; }

        [JsonProperty("wind")]
        public Wind Wind { get; set; }

        [JsonProperty("clouds")]
        public Clouds Clouds { get; set; }

        [JsonIgnore]
        public long Dt { get; set; }

        [JsonIgnore]
        public Sys Sys { get; set; }

        [JsonIgnore]
        public string Timezone { get; set; }

        [JsonIgnore]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonIgnore]
        public long Cod { get; set; }

        [JsonProperty("rain")]
        public Rain Rain { get; set; }

        public WeatherData()
        {

        }
    }
}

