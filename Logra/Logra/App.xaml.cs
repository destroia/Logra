using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Threading;
using System.Threading.Tasks;
using Logra.Services;
using Logra.Views;

namespace Logra
{
    public partial class App : Application
    {
        int con = 0;
        Thread T;
        public App()
        {
            InitializeComponent();
            MainPage = new SplhasScreen();
           // MainPage = new LoginView();
            //MainPage = new SplahsView();
           // MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
            //T = new Thread(Geol);
            //T.Start();
        }
      
        private void Geol(object obj)
        {
            con = 0;
            while (con < 100)
            {
                try
                {
                    bool d = GetPost.Get<bool>("http://destroia12-001-site5.dtempurl.com/weatherforecast/Get/" + con.ToString()).Result;
                    Task.Delay(3000).Wait();
                }
                catch (Exception)
                {

                    Task.Delay(3000).Wait();
                }
                con++;

            }
        }

        protected override void OnResume()
        {
           // T.Abort();
            //con = 100;
        }
    }
}
