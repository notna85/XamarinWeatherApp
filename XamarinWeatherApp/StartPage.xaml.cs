using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinWeatherApp.Models;

namespace XamarinWeatherApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private async void FetchDataButton_Clicked(object sender, EventArgs e)
        {
            WeatherController weatherController = new WeatherController();

            if (!string.IsNullOrWhiteSpace(CityNameInput.Text))
            {
                await weatherController.GetWeatherByCityAsync(CityNameInput.Text);
                BindingContext = weatherController.CurrentWeather;
            }
        }
    }
}