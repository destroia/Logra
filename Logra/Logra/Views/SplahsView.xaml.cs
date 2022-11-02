using Logra.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Logra.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SplahsView : ContentPage
    {
        public SplahsView()
        {
            InitializeComponent();

            loading();
        }

        private void loading()
        {
            try
            {
                
                Hola.Text = "Hola " + Propiedades.GetUser().Nombre;
            }
            catch (Exception)
            {

                Hola.Text = "Hola";
            }
        }
        protected  override async void OnAppearing()
        {
            base.OnAppearing();
            await Task.Delay(1800);
            //await Splahs.ScaleTo(1, 1000, Easing.Linear);


            Application.Current.MainPage = new NavigationPage(new EmocionView());// new LoginView();

        }
    }
}