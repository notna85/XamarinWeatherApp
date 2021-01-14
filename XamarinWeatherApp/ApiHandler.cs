using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XamarinWeatherApp.Interfaces;
using XamarinWeatherApp.Models;
using XamarinWeatherApp.Models.OneCallAPI;


namespace XamarinWeatherApp
{
    class ApiHandler : ICommunication<Forecast>
    {
        private HttpClient httpClient;

        public ApiHandler()
        {
            httpClient = new HttpClient();
        }

        public async Task<Forecast> FetchDataAsync(string requestUrl)
        {
            Forecast forecast = null;
            HttpResponseMessage httpResponse = await httpClient.GetAsync(requestUrl);

            if (httpResponse.IsSuccessStatusCode)
            {
                string content = await httpResponse.Content.ReadAsStringAsync();
                ISerialize<Forecast> serializer = new JSONSerializer<Forecast>();
                forecast = serializer.DeSerialize(content);
            }
            return forecast;
        }
    }
}
