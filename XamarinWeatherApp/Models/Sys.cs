using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XamarinWeatherApp.Models
{
    public class Sys
    {
        public long Type { get; set; }
        public long Id { get; set; }
        public string Country { get; set; }
        public long Sunrise { get; set; }
        public long Sunset { get; set; }

        public Sys()
        {

        }
    }
}
