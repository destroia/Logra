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
    public partial class PoupView // : ContentPage
    {
        string Texto = "";
        public PoupView()
        {
            InitializeComponent();
        }
        public PoupView(string text)
        {
            InitializeComponent();
            Texto = text;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            textoInfo.Text = Texto;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAsync(true);
        }
    }
}