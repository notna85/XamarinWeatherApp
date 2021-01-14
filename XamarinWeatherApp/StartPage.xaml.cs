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
                if (weatherController.Forecast != null)
                    BindingContext = weatherController.Forecast;
                else
                    await DisplayAlert("Error", "No city with that name found", "OK");

            }
            else
                await DisplayAlert("No city", "Please input a city first.", "OK");
        }
    }
}