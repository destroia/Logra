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
using XLabs.Forms.Controls;

namespace Logra.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedView : TabbedPage
    {
        List<Question> questions;
        string[] Respuestas = new string[]{ "Nunca" ,"Casi nunca" , "A veces" , "Casi siempre", "Siempre" };
        bool isSlader = false;
        byte con = 0;
        int idRdBtn = 0;
        List<Answer> Answers = new List<Answer>();
        public TabbedView()
        {
            InitializeComponent();
            
            Loadding();
        }

        private void Loadding()
        {
            //IsSlider.HeightRequest = 0;
            //IsRadioBtn.HeightRequest = 0;
            //IsSlider.IsEnabled = false;
            //IsRadioBtn.IsEnabled = false;
            RadioGroup.ItemsSource = Respuestas;
            RadioGroup.CheckedChanged += RadioGroup_CheckedChanged;
            RadioGroup.Items[0].Checked = true;
            RadioGroup.Items[0].TextColor = Color.Green;
            RadioGroup.Items[1].TextColor = Color.LightGreen;
            RadioGroup.Items[2].TextColor = Color.LightBlue;
            RadioGroup.Items[3].TextColor = Color.OrangeRed;
            RadioGroup.Items[4].TextColor = Color.Blue;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            Acty.IsRunning = true;
            Btn.IsEnabled = false;

            questions = await QuestionsService.GetQuestions(Propiedades.GetUser().Id);

            if (questions == null)
            {
                Pregunta.Text = "En este momento no hay preguntas disponibles";
                Btn.IsVisible = false;
                BtnEnviar.IsVisible = false;
                BtnEnviar.IsEnabled = false;
                IsSlider.HeightRequest = 0;
                IsSlider.IsEnabled = false;
                IsRadioBtn.HeightRequest = 0;
                IsRadioBtn.IsEnabled = false;
                IsSlider.IsVisible = false;
                IsRadioBtn.IsVisible = false;
            }
            else
            {
                Btn.IsVisible = true;
                Btn.IsEnabled = true;

            }
            Acty.IsRunning = false;
            if (questions != null)
            {
                BtnEnviar.IsVisible = false;
                BtnEnviar.IsEnabled = false;

                if (questions.Count >= 1)
                {
                    Pregunta.Text = questions[con].Pregunta;
                    isSlader = questions[con].IsSlider;
                }
                if (isSlader)
                {
                    strValor.Text = Respuestas[0];
                    IsSlider.HeightRequest = 200;
                    IsSlider.IsEnabled = true;
                    IsRadioBtn.HeightRequest = 0;
                    IsRadioBtn.IsEnabled = false;
                    IsRadioBtn.IsVisible = false;
                }
                else
                {
                    IsSlider.HeightRequest = 0;
                    IsSlider.IsEnabled = false;
                    IsRadioBtn.HeightRequest = 200;
                    IsRadioBtn.IsEnabled = true;
                    IsSlider.IsVisible = false;
                }
            }
           
            

        }

        private void RadioGroup_CheckedChanged(object sender, int e)
        {
            var radio = sender as CustomRadioButton;

            idRdBtn = radio.Id;
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {   
            
            Answer answer = new Answer();
            User usu = Propiedades.GetUser();

            answer.IdQuestion = questions[con].Id;
            answer.IdUser = usu.Id;
            answer.Pregunta = questions[con].Pregunta;
            if (isSlader)
            {
              
                if (Slider.Value >= 0 && Slider.Value < 0.20)
                {
                    answer.Respuesta = Respuestas[0];
                }
                else if (Slider.Value >= 0.20 && Slider.Value < 0.40)
                {
                    answer.Respuesta = Respuestas[1];
                }
                else if (Slider.Value >= 0.40 && Slider.Value < 0.60)
                {
                    answer.Respuesta = Respuestas[2];
                }
                else if (Slider.Value >= 0.60 && Slider.Value < 0.80)
                {
                    answer.Respuesta = Respuestas[3];
                }
                else if (Slider.Value >= 0.80 && Slider.Value <= 1)
                {
                    answer.Respuesta = Respuestas[4];
                }
                
            }
            else
            {
                answer.Respuesta = Respuestas[idRdBtn];
            }

             Answers.Add(answer);
            con++;
            if (con < questions.Count)
            {
                
                Pregunta.Text = questions[con].Pregunta;
                isSlader = questions[con].IsSlider;
                if (isSlader)
                {
                    
                    IsSlider.HeightRequest = 200;
                    IsSlider.IsEnabled = true;
                    IsSlider.IsVisible = true;
                    IsRadioBtn.HeightRequest = 0;
                    IsRadioBtn.IsEnabled = false;
                    IsRadioBtn.IsVisible = false;

                }else if (!isSlader)
                {
                    IsSlider.IsVisible = false;
                    IsSlider.HeightRequest = 0;
                    IsSlider.IsEnabled = false;
                    IsSlider.IsVisible = false;
                    IsRadioBtn.HeightRequest = 200;
                    IsRadioBtn.IsEnabled = true;
                    IsRadioBtn.IsVisible = true; 
                }

            }
            else
            {

                Pregunta.Text = "Por favor presiona el botón enviar para guardar las respuestas ";
                IsSlider.HeightRequest = 0;
                IsRadioBtn.HeightRequest = 0;
                IsRadioBtn.IsEnabled = false;
                IsRadioBtn.IsVisible = false;
                IsSlider.IsVisible = false;
                IsSlider.IsEnabled = false;
                Btn.IsVisible = false;
                Btn.IsEnabled = false;
                BtnEnviar.IsVisible = true;
                BtnEnviar.IsEnabled = true;
            }

        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (e.NewValue >= 0 && e.NewValue < 0.20)
            {
                strValor.Text = Respuestas[0];
            }
            else if (e.NewValue >= 0.20 && e.NewValue < 0.40)
            {
                strValor.Text = Respuestas[1];
            }
            else if (e.NewValue >= 0.40 && e.NewValue < 0.60)
            {
                strValor.Text = Respuestas[2];
            }
            else if (e.NewValue >= 0.60 && e.NewValue < 0.80)
            {
                strValor.Text = Respuestas[3];
            }
            else if (e.NewValue >= 0.80 && e.NewValue <= 1)
            {
                strValor.Text = Respuestas[4];
            }
            
        }

        private async  void BtnEnviar_Clicked(object sender, EventArgs e)
        {
            bool res = await AnswersService.PostAnswes(Answers);

            if (res)
            {
                await PopupNavigation.Instance.PushAsync(new PoupView("Las respuestas han sido enviadas con éxito "));
                Pregunta.Text = "A finalizado el test\n Felicitaciones 🥳🥳🥳 ";
            }
            else
            {
                await PopupNavigation.Instance.PushAsync(new PoupView("A ocurrido algo inesperado, foavor intente otro vez"));
            }
            BtnEnviar.IsVisible = false;
            BtnEnviar.IsEnabled = false;
        }
    }
}