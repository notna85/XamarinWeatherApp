using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XamarinWeatherApp.Models
{
    public class Wind
    {
        public double Speed { get; set; }
        public long Deg { get; set; }

        public Wind()
        {

        }
    }
}
