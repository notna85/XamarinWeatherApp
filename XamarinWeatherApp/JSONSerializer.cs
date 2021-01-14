using System;
using System.Collections.Generic;
using System.Text;
using XamarinWeatherApp.Interfaces;
using XamarinWeatherApp.Models;
using XamarinWeatherApp.Models.OneCallAPI;
using Newtonsoft.Json;

namespace XamarinWeatherApp
{
    class JSONSerializer<T> : ISerialize<T>
    {
        public T DeSerialize(string request)
        {
            return JsonConvert.DeserializeObject<T>(request);
        }

        public string Serialize(T t)
        {
            throw new NotImplementedException();
        }
    }
}
