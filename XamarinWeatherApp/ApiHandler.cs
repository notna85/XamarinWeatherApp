using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XamarinWeatherApp.Interfaces;
using XamarinWeatherApp.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace XamarinWeatherApp
{
    class ApiHandler : ICommunication<WeatherData>
    {
        private HttpClient httpClient;

        public ApiHandler()
        {
            httpClient = new HttpClient();
        }

        public async Task<WeatherData> FetchDataAsync(string requestUrl)
        {
            WeatherData weather = null;
            HttpResponseMessage httpResponse = await httpClient.GetAsync(requestUrl);

            if (httpResponse.IsSuccessStatusCode)
            {
                string content = await httpResponse.Content.ReadAsStringAsync();
                weather = JsonConvert.DeserializeObject <WeatherData>(content);        
            }
            return weather;
        }
    }
}
