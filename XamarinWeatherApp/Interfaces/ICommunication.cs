using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace XamarinWeatherApp.Interfaces
{
    interface ICommunication<T>
    {
        Task<T> FetchDataAsync(string url);
    }
}
