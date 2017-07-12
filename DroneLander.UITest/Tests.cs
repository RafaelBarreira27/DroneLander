using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace DroneLander.UITest
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            app.Tap(x => x.Button("Start"));
            app.Screenshot("The app in progress.");
            app.Flash(x => x.Text("Sign In"));
            app.SetOrientationLandscape();
            app.PressVolumeDown();
            app.PressVolumeDown();
            app.SetOrientationPortrait();
            app.Flash(x => x.Button("Reset"));
            app.PressVolumeUp();
            app.PressVolumeUp();
        }
    }
}

