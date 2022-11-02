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
    public partial class EmocionView : ContentPage
    {
        List<Word> LWord;
        Mood mood = new Mood();
        public EmocionView()
        {
            InitializeComponent();

           
           
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            Emociones.TranslationY = 200;
            FraPalabras.IsVisible = false;

            await PopupNavigation.Instance.PushAsync(new PoupView("Antes de seguir, cuéntame\n ¿Cómo te sientes hoy ?"));


            Acty.IsRunning = true;

            DesactivarBtn();
            LWord = await WordService.GetWord();
            Acty.IsRunning = false;
        }

        void DesactivarBtn()
        {
            #region botones
            btn1.IsVisible = false;
            btn2.IsVisible = false;
            btn3.IsVisible = false;
            btn4.IsVisible = false;
            btn5.IsVisible = false;
            btn6.IsVisible = false;
            btn7.IsVisible = false;
            btn8.IsVisible = false;
            btn9.IsVisible = false;
            btn10.IsVisible = false;
            btn11.IsVisible = false;
            btn12.IsVisible = false;
            btn13.IsVisible = false;
            btn14.IsVisible = false;
            btn15.IsVisible = false;
            btn16.IsVisible = false;

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
            #endregion
        }
       
        void IsvisiblePalabras(string color, List<string> LP)
        {
            int numero = LP.Count;
            if (numero >= 1)
            {
                btn1.IsVisible = true;
                btn1.BackgroundColor = Color.FromHex(color);
                btn1.Text = LP[0];
                btn1.IsEnabled = true;
            }
            if (numero >= 2)
            {
                btn2.IsVisible = true;
                btn2.BackgroundColor = Color.FromHex(color);
                btn2.Text = LP[1];
                btn2.IsEnabled = true;
            }
            if (numero >= 3)
            {
                btn3.IsVisible = true;
                btn3.BackgroundColor = Color.FromHex(color);
                btn3.Text = LP[2];
                btn3.IsEnabled = true;
            }
            if (numero >= 4)
            {
                btn4.IsVisible = true;
                btn4.BackgroundColor = Color.FromHex(color);
                btn4.Text = LP[3];
                btn4.IsEnabled = true;
            }
            if (numero >= 5)
            {
                btn5.IsVisible = true;
                btn5.BackgroundColor = Color.FromHex(color);
                btn5.Text = LP[4];
                btn5.IsEnabled = true;
            }
            if (numero >= 6)
            {
                btn6.IsVisible = true;
                btn6.BackgroundColor = Color.FromHex(color);
                btn6.Text = LP[5];
                btn6.IsEnabled = true;
            }
            if (numero >= 7)
            {
                btn7.IsVisible = true;
                btn7.BackgroundColor = Color.FromHex(color);
                btn7.Text = LP[6];
                btn7.IsEnabled = true;
            }
            if (numero >= 8)
            {
                btn8.IsVisible = true;
                btn8.BackgroundColor = Color.FromHex(color);
                btn8.Text = LP[7];
                btn8.IsEnabled = true;
            }
            if (numero >= 9)
            {
                btn9.IsVisible = true;
                btn9.BackgroundColor = Color.FromHex(color);
                btn9.Text = LP[8];
                btn9.IsEnabled = true;
            }
            if (numero >= 10)
            {
                btn10.IsVisible = true;
                btn10.BackgroundColor = Color.FromHex(color);
                btn10.Text = LP[9];
                btn10.IsEnabled = true;
            }
            if (numero >= 11)
            {
                btn11.IsVisible = true;
                btn11.BackgroundColor = Color.FromHex(color);
                btn11.Text = LP[10];
                btn11.IsEnabled = true;
            }
            if (numero >= 12)
            {
                btn12.IsVisible = true;
                btn12.BackgroundColor = Color.FromHex(color);
                btn12.Text = LP[11];
                btn12.IsEnabled = true;
            }
            if (numero >= 13)
            {
                btn13.IsVisible = true;
                btn13.BackgroundColor = Color.FromHex(color);
                btn13.Text = LP[12];
                btn13.IsEnabled = true;
            }
            if (numero >= 14)
            {
                btn14.IsVisible = true;
                btn14.BackgroundColor = Color.FromHex(color);
                btn14.Text = LP[13];
                btn14.IsEnabled = true;
            }
            if (numero >= 15)
            {
                btn15.IsVisible = true;
                btn15.BackgroundColor = Color.FromHex(color);
                btn15.Text = LP[14];
                btn15.IsEnabled = true;
            }
            if (numero >= 16)
            {
                btn16.IsVisible = true;
                btn16.BackgroundColor = Color.FromHex(color);
                btn16.Text = LP[15];
                btn16.IsEnabled = true;
            }


        }
        async Task<bool> IsLoad()
        {
            if (LWord == null)
            {
                await DisplayAlert("Información", "Debe esperar un momento mientras que se cargan las palabra.", "Aceptar");
                return false;
            }
            {
                return true;
            }
        }
        private async void Button_EmoFeliz(object sender, EventArgs e)
        {
            if ( !await IsLoad())
            {
                return;
            }

            DesactivarBtn();

            Emociones.TranslationY = 0;
            FraPalabras.IsVisible = true;

           imgFeliz.ScaleTo(1, 700, Easing.Linear);

           imgMalHumor.ScaleTo(0.8, 700, Easing.Linear);
           imgEstres.ScaleTo(0.8, 700, Easing.Linear);
           imgTristeza.ScaleTo(0.8, 700, Easing.Linear);
           imgMatoneo.ScaleTo(0.8, 700, Easing.Linear);

 
            CategoriaWord.Text = "Palabras de felicidad";
            var LPalabrasByEmocion = LWord.Where(x => x.Emocion == "Felicidad").Select( x => x.Palabra).ToList();
            FraPalabras.BackgroundColor = Color.FromHex("#F5A769");
            IsvisiblePalabras("#F5A769", LPalabrasByEmocion);

            mood.Emocion = "Felicidad";
        }

        private async void Button_MalHumor(object sender, EventArgs e)
        {
            if (!await IsLoad())
            {
                return;
            }

            DesactivarBtn();

            Emociones.TranslationY = 0;
            FraPalabras.IsVisible = true;

            imgMalHumor.ScaleTo(1, 700, Easing.Linear);

            imgFeliz.ScaleTo(0.8, 700, Easing.Linear);
            imgEstres.ScaleTo(0.8, 700, Easing.Linear);
            imgTristeza.ScaleTo(0.8, 700, Easing.Linear);
            imgMatoneo.ScaleTo(0.8, 700, Easing.Linear);

            CategoriaWord.Text = "Palabras de mal humor";
            var LPalabrasByEmocion = LWord.Where(x => x.Emocion == "mal humor").Select(x => x.Palabra).ToList();
            FraPalabras.BackgroundColor = Color.FromHex("#AF437E");
            IsvisiblePalabras("#AF437E", LPalabrasByEmocion);

            mood.Emocion = "mal humor";

        }

        private async  void Button_Triesteza(object sender, EventArgs e)
        {
            if (!await IsLoad())
            {
                return;
            }

            DesactivarBtn();

            Emociones.TranslationY = 0;
            FraPalabras.IsVisible = true;

            imgTristeza.ScaleTo(1, 700, Easing.Linear);

            imgFeliz.ScaleTo(0.8, 700, Easing.Linear);
            imgMalHumor.ScaleTo(0.8, 700, Easing.Linear);
            imgEstres.ScaleTo(0.8, 700, Easing.Linear);
            imgMatoneo.ScaleTo(0.8, 700, Easing.Linear);

            CategoriaWord.Text = "Palabras tristes";

            var LPalabrasByEmocion = LWord.Where(x => x.Emocion == "triste").Select(x => x.Palabra).ToList();
            IsvisiblePalabras("#6F4E94", LPalabrasByEmocion);
            FraPalabras.BackgroundColor = Color.FromHex("#6F4E94");

            mood.Emocion = "triste";
        }

        private async void Button_Estres(object sender, EventArgs e)
        {
            if (!await IsLoad())
            {
                return;
            }

            DesactivarBtn();

            Emociones.TranslationY = 0;
            FraPalabras.IsVisible = true;

            imgEstres.ScaleTo(1, 700, Easing.Linear);

            imgTristeza.ScaleTo(0.8, 700, Easing.Linear);
            imgFeliz.ScaleTo(0.8, 700, Easing.Linear);
            imgMalHumor.ScaleTo(0.8, 700, Easing.Linear);
            imgMatoneo.ScaleTo(0.8, 700, Easing.Linear);

            CategoriaWord.Text = "Palabras de estrés";

            var LPalabrasByEmocion = LWord.Where(x => x.Emocion == "estres").Select(x => x.Palabra).ToList();
            IsvisiblePalabras("#669AAE", LPalabrasByEmocion);
            FraPalabras.BackgroundColor = Color.FromHex("#669AAE");

            mood.Emocion = "estres";
        }

        private async void Button_Matoneo(object sender, EventArgs e)
        {
            if (!await IsLoad())
            {
                return;
            }

            DesactivarBtn();

            Emociones.TranslationY = 0;
            FraPalabras.IsVisible = true;

            imgMatoneo.ScaleTo(1, 700, Easing.Linear);

            imgEstres.ScaleTo(0.8, 700, Easing.Linear);
            imgTristeza.ScaleTo(0.8, 700, Easing.Linear);
            imgFeliz.ScaleTo(0.8, 700, Easing.Linear);
            imgMalHumor.ScaleTo(0.8, 700, Easing.Linear);

            CategoriaWord.Text = "Palabras de matoneo";

            var LPalabrasByEmocion = LWord.Where(x => x.Emocion == "matoneo").Select(x => x.Palabra).ToList();
            IsvisiblePalabras("#345885", LPalabrasByEmocion);
            FraPalabras.BackgroundColor = Color.FromHex("#345885");

            mood.Emocion = "matoneo";
        }

        #region BtnWord
        private async void btn1_Clicked(object sender, EventArgs e)
        {
            mood.Palabra = btn1.Text;
            await Application.Current.MainPage.Navigation.PushAsync(new DetonantesView(mood), true);
        }

        private async void btn2_Clicked(object sender, EventArgs e)
        {
            mood.Palabra = btn2.Text;
            await Application.Current.MainPage.Navigation.PushAsync(new DetonantesView(mood), true);
        }

        private async void btn3_Clicked(object sender, EventArgs e)
        {
            mood.Palabra = btn3.Text;
            await Application.Current.MainPage.Navigation.PushAsync(new DetonantesView(mood), true);
        }

        private async void btn4_Clicked(object sender, EventArgs e)
        {
            mood.Palabra = btn4.Text;
            await Application.Current.MainPage.Navigation.PushAsync(new DetonantesView(mood), true);
        }

        private async void btn5_Clicked(object sender, EventArgs e)
        {
            mood.Palabra = btn5.Text;
            await Application.Current.MainPage.Navigation.PushAsync(new DetonantesView(mood), true);
        }

        private async void btn6_Clicked(object sender, EventArgs e)
        {
            mood.Palabra = btn6.Text;
            await Application.Current.MainPage.Navigation.PushAsync(new DetonantesView(mood), true);
        }

        private async void btn7_Clicked(object sender, EventArgs e)
        {
            mood.Palabra = btn7.Text;
            await Application.Current.MainPage.Navigation.PushAsync(new DetonantesView(mood), true);
        }

        private async void btn8_Clicked(object sender, EventArgs e)
        {
            mood.Palabra = btn8.Text;
            await Application.Current.MainPage.Navigation.PushAsync(new DetonantesView(mood), true);
        }

        private async void btn9_Clicked(object sender, EventArgs e)
        {
            mood.Palabra = btn9.Text;
            await Application.Current.MainPage.Navigation.PushAsync(new DetonantesView(mood), true);
        }

        private async void btn10_Clicked(object sender, EventArgs e)
        {
            mood.Palabra = btn10.Text;
            await Application.Current.MainPage.Navigation.PushAsync(new DetonantesView(mood), true);
        }

        private async void btn11_Clicked(object sender, EventArgs e)
        {
            mood.Palabra = btn11.Text;
            await Application.Current.MainPage.Navigation.PushAsync(new DetonantesView(mood), true);
        }

        private async void btn12_Clicked(object sender, EventArgs e)
        {
            mood.Palabra = btn12.Text;
            await Application.Current.MainPage.Navigation.PushAsync(new DetonantesView(mood), true);
        }

        private async void btn13_Clicked(object sender, EventArgs e)
        {
            mood.Palabra = btn13.Text;
            await Application.Current.MainPage.Navigation.PushAsync(new DetonantesView(mood), true);
        }

        private async void btn14_Clicked(object sender, EventArgs e)
        {
            mood.Palabra = btn14.Text;
            await Application.Current.MainPage.Navigation.PushAsync(new DetonantesView(mood), true);
        }

        private async void btn15_Clicked(object sender, EventArgs e)
        {
            mood.Palabra = btn15.Text;
            await Application.Current.MainPage.Navigation.PushAsync(new DetonantesView(mood), true);
        }

        private async void btn16_Clicked(object sender, EventArgs e)
        {
            mood.Palabra = btn16.Text;
            await Application.Current.MainPage.Navigation.PushAsync(new DetonantesView(mood), true);
        }
        #endregion


    }
}