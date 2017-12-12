using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Exercise2
{
	public partial class MainPage : ContentPage
	{


        public MainPage()
		{
			InitializeComponent();
		}

        //        void OnButtonClicked(object sender, EventArgs args)
        //        {
        //            var result = await this.DisplayAlert("Notification", "Do you want store this Number ?", "Yes", "No");

        ////            Navigation.PushAsync(new AboutUs());
        //        }

        //protected override bool OnBackButtonPressed()
        //{
        //    Device.BeginInvokeOnMainThread(async () => {
        //        var result = await this.DisplayAlert("Alert!", "Do you really want to exit?", "Yes", "No");
        //        if (result) await this.Navigation.PopAsync(); // or anything else
        //    });

        //    return true;
        //}

        private async void Button_Onclick(object sender, EventArgs e)
        {
            //Device.BeginInvokeOnMainThread(async () => {
            //    var result = await this.DisplayAlert("Alert!", "Do you really want to continue?", "Yes", "No");
            //    if (result) await Navigation.PushAsync(new Sample()); // or anything else
            //});
            //return true;

            var result = await DisplayAlert("title", "Hello", "OK", "Cancel");
            if (result.Equals(true))
            {
            Navigation.PushAsync(new AboutUs());
            }
        }

    }
}
