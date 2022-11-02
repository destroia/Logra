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
    public partial class RegistroView : ContentPage
    {
        public RegistroView()
        {
            InitializeComponent();
            Usuario.Text = "";
            Contrasena.Text = "";
            ConfirmaContrasena.Text = "";
            Email.Text = "";
            codigo.Text = "";

        }

        private async void Button_Guardar(object sender, EventArgs e)
        {
            if (Usuario.Text != "" || Contrasena.Text!= "" || ConfirmaContrasena.Text != "" || Email.Text != "" || codigo.Text.Length <=4) 
            {
                if (Usuario.Text.Length >= 5 && (Contrasena.Text == ConfirmaContrasena.Text) && Email.Text.Length >= 8 && codigo.Text.Length == 5 && Contrasena.Text.Length >= 4)
                { 
                    BtnCancelar.IsEnabled = false;
                    ACty.IsRunning = true;
                    Guardar.IsEnabled = false;

                    try
                    {
                        var res = await UserService.PostUpdateRegistroUser(new User()
                        {
                            Email = Email.Text,
                            Codigo = codigo.Text,
                            Contraseña = Contrasena.Text,
                            UserName = Usuario.Text
                        });
                        if (res.Codigo.Length == 5)
                        {
                            await DisplayAlert("Logra +", "Se ha creado un usuario.", "Aceptar");
                            Application.Current.MainPage = new LoginView();
                        }
                        else if (res != null && res.Codigo == "0")
                        {
                            await DisplayAlert("Logra +", "Código erróneo por favor verifíquelo y vuelva a intentar de nuevo.", "Aceptar");
                        }
                        else
                        {
                            await DisplayAlert("Logra +", "A ocurrido un error.", "Aceptar");
                        }
                    }
                    catch (Exception)
                    {

                        await PopupNavigation.Instance.PushAsync(new PoupView("A ocurrido un error"));
                    }
                    
                    Guardar.IsEnabled = true;
                    ACty.IsRunning = false;
                    BtnCancelar.IsEnabled = true;
                }
                else if(Usuario.Text.Length <=4)
                {
                    await DisplayAlert("Logra +", "El campo usuario debe de tener más de cinco caracteres.", "Aceptar");
                   // await DisplayAlert("Error", "Uno de los campos es in correcto por favor verifica y vuelve a intentar.", "Aceptar");
                }else if (Contrasena.Text != ConfirmaContrasena.Text  || Contrasena.Text == "" )
                {
                    await DisplayAlert("Logra +", "La confirmación de la contraseña es distinto" +
                        " a su confirmación por favor validar la confirmación.", "Aceptar");
                }else if(codigo.Text.Length != 5)
                {
                    await DisplayAlert("Logra +", "La licencia o código tiene que ser de cinto caracteres.", "Aceptar");
                }else if(Email.Text.Length <=7)
                {
                    await DisplayAlert("Logra +", "El correo debe ser de ocho o más caracteres.", "Aceptar");
                }else if(Contrasena.Text.Length <= 3)
                {
                    await DisplayAlert("Logra +", "La contraseña debe tener cuatro o más caracteres.", "Aceptar");
                }
            }
            else 
            {
                await DisplayAlert("Logra +", "Debe llenar todos los campos.", "Aceptar");
            }
            
           
        }

        private void Button_Cancelar(object sender, EventArgs e)
        {
            Application.Current.MainPage = new LoginView();
        }
    }
}