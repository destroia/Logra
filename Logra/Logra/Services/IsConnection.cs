using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Logra.Services
{
    public class IsConnection
    {
        public static async Task<bool> IsConnect()
        {
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                return true;
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Error", "Verifique conexión a internet.", "Aceptar");
                return false;
            }
        }

    }
}
