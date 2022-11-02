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
    public partial class DetonantesView : ContentPage
    {
        private Mood mood;
        string detonante = "000";
        public DetonantesView()
        {
            InitializeComponent();
        }

        public DetonantesView(Mood mood)
        {
            InitializeComponent();
            this.mood = mood;
        }

        void DesmarcarImg()
        {
            imgBtn1.Source = "Trabajo.png";
            imgBtn2.Source = "Escuela.png";
            imgBtn3.Source = "CaminoEscuela.png";
            imgBtn4.Source = "Pareja.png";
            imgBtn5.Source = "Soledad.png";
            imgBtn6.Source = "Familia.png";
            imgBtn7.Source = "Amigo.png";
            imgBtn8.Source = "RedSocial.png";
            imgBtn9.Source = "Dormi.png";
            imgBtn10.Source = "NoDormi.png";
            imgBtn11.Source = "Sedentario.png";
            imgBtn12.Source = "Ejercicio.png";
            imgBtn13.Source = "Cuerpo.png";
            imgBtn14.Source = "Salud.png";
            imgBtn15.Source = "Sexo.png";
            imgBtn16.Source = "Aseo.png";
            imgBtn17.Source = "Clima.png";
            imgBtn18.Source = "Aire.png";

            btn1.BorderColor = Color.White;
            btn2.BorderColor = Color.White;
            btn3.BorderColor = Color.White;
            btn4.BorderColor = Color.White;
            btn5.BorderColor = Color.White;
            btn6.BorderColor = Color.White;
            btn7.BorderColor = Color.White;
            btn8.BorderColor = Color.White;
            btn9.BorderColor = Color.White;
            btn10.BorderColor = Color.White;
            btn11.BorderColor = Color.White;
            btn12.BorderColor = Color.White;
            btn13.BorderColor = Color.White;
            btn14.BorderColor = Color.White;
            btn15.BorderColor = Color.White;
            btn16.BorderColor = Color.White;
            btn17.BorderColor = Color.White;
            btn18.BorderColor = Color.White;

            imgBtn1.Scale = 0.5;
            imgBtn2.Scale = 0.5;
            imgBtn3.Scale = 0.5;
            imgBtn4.Scale = 0.5;
            imgBtn5.Scale = 0.5;
            imgBtn6.Scale = 0.5;
            imgBtn7.Scale = 0.5;
            imgBtn8.Scale = 0.5;
            imgBtn9.Scale = 0.5;
            imgBtn10.Scale = 0.5;
            imgBtn11.Scale = 0.5;
            imgBtn12.Scale = 0.5;
            imgBtn13.Scale = 0.5;
            imgBtn14.Scale = 0.5;
            imgBtn15.Scale = 0.5;
            imgBtn16.Scale = 0.5;
            imgBtn17.Scale = 0.5;
            imgBtn18.Scale = 0.5;

            //btn1.BackgroundColor = Color.Transparent ;
            //btn2.BackgroundColor = Color.Transparent;
            //btn3.BackgroundColor = Color.Transparent;
            //btn4.BackgroundColor = Color.Transparent;
            //btn5.BackgroundColor = Color.Transparent;
            //btn6.BackgroundColor = Color.Transparent;
            //btn7.BackgroundColor = Color.Transparent;
            //btn8.BackgroundColor = Color.Transparent;
            //btn9.BackgroundColor = Color.Transparent;
            //btn10.BackgroundColor = Color.Transparent;
            //btn11.BackgroundColor = Color.Transparent;
            //btn12.BackgroundColor = Color.Transparent;
            //btn13.BackgroundColor = Color.Transparent;
            //btn14.BackgroundColor = Color.Transparent;
            //btn15.BackgroundColor = Color.Transparent;
            //btn16.BackgroundColor = Color.Transparent;
            //btn17.BackgroundColor = Color.Transparent;
            //btn18.BackgroundColor = Color.Transparent;

        }

        private void Button_btn1(object sender, EventArgs e)
        {
            DesmarcarImg();
            imgBtn1.Source = "TrabajoN.png";
            imgBtn1.Scale = 1.3;
            btn1.BorderColor = Color.Transparent;
            detonante = "Trabajo";

        }

        private void Button_btn2(object sender, EventArgs e)
        {
            DesmarcarImg();
            imgBtn2.Source = "EscuelaN.png";
            imgBtn2.Scale = 1.3;
            btn2.BorderColor = Color.Transparent;
            detonante = "Escuela";
        }

        private void Button_btn3(object sender, EventArgs e)
        {
            DesmarcarImg();
            imgBtn3.Source = "CaminoEscuelaN.png";
            imgBtn3.Scale = 1.3;
            btn3.BorderColor = Color.Transparent;
            detonante = "Camino a la escuela";
        }

        private void Button_btn4(object sender, EventArgs e)
        {
            DesmarcarImg();
            imgBtn4.Source = "ParejaN.png";
            imgBtn4.Scale = 1.3;
            btn4.BorderColor = Color.Transparent;
            detonante = "Pareja";
        }

        private void Button_btn5(object sender, EventArgs e)
        {
            DesmarcarImg();
            imgBtn5.Source = "SoledadN.png";
            imgBtn5.Scale = 1.3;
            btn5.BorderColor = Color.Transparent;
            detonante = "Estar solo";
        }

        private void Button_btn6(object sender, EventArgs e)
        {
            DesmarcarImg();
            imgBtn6.Source = "FamiliaN.png";
            imgBtn6.Scale = 1.3;
            btn6.BorderColor = Color.Transparent;
            detonante = "Familia";
        }

        private void Button_btn7(object sender, EventArgs e)
        {
            DesmarcarImg();
            imgBtn7.Source = "AmigoN.png";
            imgBtn7.Scale = 1.3;
            btn7.BorderColor = Color.Transparent;
            detonante = "Amigos";
        }

        private void Button_btn8(object sender, EventArgs e)
        {
            DesmarcarImg();
            imgBtn8.Source = "RedSocialN.png";
            imgBtn8.Scale = 1.3;
            btn8.BorderColor = Color.Transparent;
            detonante = "Redes sociales";
        }

        private void Button_btn9(object sender, EventArgs e)
        {
            DesmarcarImg();
            imgBtn9.Source = "DormiN.png";
            imgBtn9.Scale = 1.3;
            btn9.BorderColor = Color.Transparent;
            detonante = "Dormi bien";
        }

        private void Button_btn10(object sender, EventArgs e)
        {
            DesmarcarImg();
            imgBtn10.Source = "NoDormiN.png";
            imgBtn10.Scale = 1.3;
            btn10.BorderColor = Color.Transparent;
            detonante = "Dormi mal";
        }

        private void Button_btn11(object sender, EventArgs e)
        {
            DesmarcarImg();
            imgBtn11.Source = "SedentarioN.png";
            imgBtn11.Scale = 1.3;
            btn11.BorderColor = Color.Transparent;
            detonante = "Sedentario";
        }

        private void Button_btn12(object sender, EventArgs e)
        {
            DesmarcarImg();
            imgBtn12.Source = "EjercicioN.png";
            imgBtn12.Scale = 1.3;
            btn12.BorderColor = Color.Transparent;
            detonante = "Ejercicio";
        }

        private void Button_btn13(object sender, EventArgs e)
        {
            DesmarcarImg();
            imgBtn13.Source = "CuerpoN.png";
            imgBtn13.Scale = 1.3;
            btn13.BorderColor = Color.Transparent;
            detonante = "Mi cuerpo";
        }

        private void Button_btn14(object sender, EventArgs e)
        {
            DesmarcarImg();
            imgBtn14.Source = "SaludN.png";
            imgBtn14.Scale = 1.3;
            btn14.BorderColor = Color.Transparent;
            detonante = "Salud";
        }

        private void Button_btn15(object sender, EventArgs e)
        {
            DesmarcarImg();
            imgBtn15.Source = "SexoN.png";
            imgBtn15.Scale = 1.3;
            btn15.BorderColor = Color.Transparent;
            detonante = "Sexo";
        }

        private void Button_btn16(object sender, EventArgs e)
        {
            DesmarcarImg();
            imgBtn16.Source = "AseoN.png";
            imgBtn16.Scale = 1.3;
            btn16.BorderColor = Color.Transparent;
            detonante = "Aseo";
        }

        private void Button_btn17(object sender, EventArgs e)
        {
            DesmarcarImg();
            imgBtn17.Source = "ClimaN.png";
            imgBtn17.Scale = 1.3;
            btn17.BorderColor = Color.Transparent;
            detonante = "Clima";
        }

        private void Button_btn18(object sender, EventArgs e)
        {
            DesmarcarImg();
            imgBtn18.Source = "AireN.png";
            imgBtn18.Scale = 1.3;
            btn18.BorderColor = Color.Transparent;
            detonante = "El Aire";
        }

        void DesacivarBtn()
        {
            btn1.IsEnabled = false;
            btn2.IsEnabled = false;
            btn3.IsEnabled = false;
            btn4.IsEnabled = false;
            btn5.IsEnabled = false;
            btn6.IsEnabled = false;
            btn7.IsEnabled = false;
            btn8.IsEnabled = false;
            btn9.IsEnabled = false;
            btn10.IsEnabled = false;
            btn11.IsEnabled = false;
            btn12.IsEnabled = false;
            btn13.IsEnabled = false;
            btn14.IsEnabled = false;
            btn15.IsEnabled = false;
            btn16.IsEnabled = false;
            btn17.IsEnabled = false;
            btn18.IsEnabled = false;
        }
        void ActivarBtn()
        {
            btn1.IsEnabled = true;
            btn2.IsEnabled = true;
            btn3.IsEnabled = true;
            btn4.IsEnabled = true;
            btn5.IsEnabled = true;
            btn6.IsEnabled = true;
            btn7.IsEnabled = true;
            btn8.IsEnabled = true;
            btn9.IsEnabled = true;
            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;
            btn13.IsEnabled = true;
            btn14.IsEnabled = true;
            btn15.IsEnabled = true;
            btn16.IsEnabled = true;
            btn17.IsEnabled = true;
            btn18.IsEnabled = true;
        }
        private async void Button_Continuar(object sender, EventArgs e)
        {
            if (detonante == "000")
            {
                await PopupNavigation.Instance.PushAsync(new PoupView("Es necesario seleccionar un icono para continuar"));
            }
            else if(detonante != "000")
            {
                mood.Detonante = detonante;

                Acty.IsRunning = true;
                Continuar.IsEnabled = false;
                DesacivarBtn();
                var usu = Propiedades.GetUser();

                mood.IdGarden = usu.IdGarden;
                mood.IdInstitution = usu.IdInstutition;
                mood.IdUser = usu.Id;

                bool res = await MoodService.PostMood(mood);

                if (res)
                {
                    await PopupNavigation.Instance.PushAsync(new PoupView("La información será procesada \nTe deseamos un lindo día ☺️☺️☺️"));
                    Application.Current.MainPage = new TabbedView();
                }
                else
                {
                    await PopupNavigation.Instance.PushAsync(new PoupView("A ocurrido un error \n 😓😓😓"));
                }
                ActivarBtn();
                Acty.IsRunning = false;
                Continuar.IsEnabled = true;
            }
        }
    }
}