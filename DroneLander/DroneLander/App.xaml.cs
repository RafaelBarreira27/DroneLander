using DroneLander.PageModels;
using DroneLander.Services;
using FreshMvvm;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DroneLander
{
    public partial class App : Application
    {
        public static PageModels.MainPageModel PageModel { get; set; }

        public static Services.IAuthenticationService Authenticator { get; private set; }

        public static void InitializeAuthentication(Services.IAuthenticationService authenticator)
        {
            Authenticator = authenticator;
        }

        public App()
        {
            SetupIOC();
            InitializeComponent();

            var page = FreshPageModelResolver.ResolvePageModel<MainPageModel>();
            var mainContainer = new FreshNavigationContainer(page);
            MainPage = mainContainer;
            
        }
        void SetupIOC()
        {
            FreshMvvm.FreshIOC.Container.Register<IScoreService, ScoreService>();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
              MobileCenter.Start($"android={Common.MobileCenterConstants.AndroidAppId};" +
              $"ios={Common.MobileCenterConstants.iOSAppId}",
              typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
