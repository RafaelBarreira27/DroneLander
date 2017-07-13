using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace DroneLander.UITest
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
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
            /*app.Tap("Sign In");
            app.WaitForElement(c => c.WebView().Css("INPUT#i0116"));
            app.EnterText(x => x.WebView().Css("INPUT#i0116"), "rafael_jorge_barreira@hotmail.com");
            app.Tap(x => x.WebView().Css("INPUT#idSIButton9"));
            app.EnterText(x => x.WebView().Css("INPUT#i0118"), "PASS");
            app.Back();
            app.Tap(x => x.WebView().Css("INPUT#idSIButton9"));*/

            app.WaitForElement("ButtonStart");
            app.Tap("ButtonStart");
            System.Threading.Thread.Sleep(50000);
            app.WaitForElement(x => x.Text("Kaboom"));
            app.Screenshot("CRASH");
            app.Tap("button2");

            app.WaitForElement("ButtonStart");
            app.Tap("ButtonStart");
            app.SetSliderValue(x => x.Class("FormsSeekBar"), 1000);
            System.Threading.Thread.Sleep(7000);
            app.Screenshot("Drone Lander in action");
            app.Tap("ButtonStart");


            //app.Repl();
        }
    }
}

