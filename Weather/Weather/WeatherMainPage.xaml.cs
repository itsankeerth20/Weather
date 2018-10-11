using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace Weather
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WeatherMainPage : ContentPage
	{
		public WeatherMainPage ()
		{
			InitializeComponent ();
            BindingContext = new WeatherModel();
            //WeatherModel wm = new WeatherModel();
            //BindingContext = wm;
        }

        private async void getWeatherBtn_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(zipCodeEntry.Text))
            {
                WeatherModel weather = await Core.GetWeather(zipCodeEntry.Text);
                BindingContext = weather;
                getWeatherBtn.Text = "Search Again";
            }

        }
    }
}