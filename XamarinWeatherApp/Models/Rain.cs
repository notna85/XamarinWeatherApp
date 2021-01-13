using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XamarinWeatherApp.Models
{
    public class Rain
    {
        [JsonProperty("1h")]
        public long OneHour { get; set; }

        [JsonProperty("3h")]
        public long ThreeHours { get; set; }

    }
}
