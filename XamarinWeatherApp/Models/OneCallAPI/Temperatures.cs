using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XamarinWeatherApp.Models.OneCallAPI
{
    class Temperatures
    {
        [JsonProperty("day")]
        public double Day { get; set; }
    }
}
