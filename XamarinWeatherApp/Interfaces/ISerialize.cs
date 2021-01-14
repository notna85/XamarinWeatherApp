using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinWeatherApp.Interfaces
{
    interface ISerialize<T>
    {
        T DeSerialize(string request);
        string Serialize(T t);
    }
}
