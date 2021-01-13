using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XamarinWeatherApp.Models
{
    public class Weather
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("main")]
        public string Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        public Weather()
        {

        }
    }
}
