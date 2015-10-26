using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace FormsNetworkConnectivity
{
    public class App : Application
    {
        public App()
        {
            MainPage =  new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            /*var container = TinyIoCContainer.Current;

            container.Register<IPlatform, ApplePlatform>();
            container.Register<ISettings, AppleSettings>();*/
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
