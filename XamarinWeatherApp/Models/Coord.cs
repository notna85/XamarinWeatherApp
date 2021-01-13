using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XamarinWeatherApp.Models
{
    public class Coord
    {
        [JsonIgnore]
        public double Lon { get; set; }
        [JsonIgnore]
        public double Lat { get; set; }

        public Coord()
        {

        }
    }
}
