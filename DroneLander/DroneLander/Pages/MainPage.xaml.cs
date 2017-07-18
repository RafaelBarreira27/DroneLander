using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DroneLander.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
		}

      /*  protected override void OnAppearing()
        {
            base.OnAppearing();

            if (App.PageModel == null) App.PageModel = new PageModels.MainPageModel(/*this);

            this.BindingContext = App.PageModel;

            MessagingCenter.Subscribe<MainPage, LandingResultType>(this, "ActivityUpdate", (sender, arg) =>
            {
                string title = arg.ToString();
                string message = (arg == LandingResultType.Landed) ? "The Eagle has landed!" : "That's going to leave a mark!";
                if (arg == LandingResultType.Kaboom) App.PageModel.ShakeLandscapeAsync(this);

                Device.BeginInvokeOnMainThread(() =>
                {
                    this.DisplayAlert(title, message, "OK");
                    App.PageModel.ResetLanding();
                });
            });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<MainPage, LandingResultType>(this, "ActivityUpdate");
        }*/

    }
}