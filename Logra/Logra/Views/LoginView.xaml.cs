using Logra.Services;
using LograModel;
using Rg.Plugins.Popup.Services;
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
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();

            codigo.Text = "";
            Contrasena.Text = "";
        }

        private async void Button_InicioSesion(object sender, EventArgs e)
        {
            if (codigo.Text == "" || Contrasena.Text == "")
            {
                await PopupNavigation.Instance.PushAsync(new PoupView("Debe ingresar todos los campos"));
            }
            else
            {
                if (codigo.Text.Length == 5 && Contrasena.Text.Length >= 4)
                {
                    InicioSesion.IsEnabled = false;
                    Registro.IsEnabled = false;
                    ACty.IsRunning = true;

                    try
                    {
                        var res = await UserService.PostInicioSesion(new User()
                        {
                            Codigo = codigo.Text,
                            Contraseña = Contrasena.Text
                        });
                        if (res.Codigo.Length == 5)
                        {
                            Propiedades.InsertUser(res);
                           //await PopupNavigation.Instance.PushAsync(new PoupView("Bienvenido a Logra+"),true);

                            Application.Current.MainPage = new SplahsView();//new NavigationPage(new EmocionView());
                        }
                        else if (res.Codigo == "0")
                        {
                            await PopupNavigation.Instance.PushAsync(new PoupView("Contraseña o código incorrecto"));
                        }
                        else
                        {
                            await PopupNavigation.Instance.PushAsync(new PoupView("A ocurrido un error"));
                        }
                    }
                    catch (Exception ex)
                    {

                        await PopupNavigation.Instance.PushAsync(new PoupView("A ocurrido un error"));
                    }
                   

                    InicioSesion.IsEnabled = true;
                    Registro.IsEnabled = true;
                    ACty.IsRunning = false;
                }
                else if (codigo.Text.Length != 5)
                {
                    await DisplayAlert("Logra +", "El código debe tener cinco caracteres.", "Aceptar");
                }
                else
                {
                    await DisplayAlert("Logra +", "La contraseña debe tener mínimo cuatro caracteres.", "Aceptar");
                }
            }
          
        }

        

        private void Button_Registro(object sender, EventArgs e)
        {
            Application.Current.MainPage = new RegistroView();
        }
    }
}