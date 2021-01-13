using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XamarinWeatherApp.Models
{
    public class Main
    {
        [JsonProperty("temp")]
        public double Temperature { get; set; }

        [JsonIgnore]
        public double Feels_Like { get; set; }

        [JsonIgnore]
        public double Temp_Min { get; set; }

        [JsonIgnore]
        public double Temp_Max { get; set; }

        [JsonIgnore]
        public long Pressure { get; set; }

        [JsonIgnore]
        public long Humidity { get; set; }

        public Main()
        {

        }
    }
}
