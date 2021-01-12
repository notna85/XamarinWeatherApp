using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XamarinWeatherApp.Interfaces;
using XamarinWeatherApp.Models;

namespace XamarinWeatherApp
{
    class ApiHandler : ICommunication<WeatherData>
    {
        HttpClient httpClient;


        public ApiHandler()
        {
            httpClient = new HttpClient();
        }


        public async Task<WeatherData> FetchDataAsync(string requestUrl)
        {
            HttpResponseMessage httpResponse = await httpClient.GetAsync(requestUrl);

            if (httpResponse.IsSuccessStatusCode)
            {
                string content = await httpResponse.Content.ReadAsStringAsync();

            }
            throw new NotImplementedException();
        }
    }
}
