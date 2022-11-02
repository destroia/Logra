using LograModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace Logra.Services
{
    public class Propiedades
    {
        static string user = "User";
        public static User GetUser()
        {
            string UserStr = App.Current.Properties[user].ToString();
            var C = JsonConvert.DeserializeObject<User>(UserStr);

            return C;
        }
        public static async void InsertUser(User Us)
        {
            string UserStr = JsonConvert.SerializeObject(Us);
            App.Current.Properties[user] = UserStr;
            await App.Current.SavePropertiesAsync();
        }
        public static async void SalirSesion()
        {
            App.Current.Properties[user] = null;
            await App.Current.SavePropertiesAsync();
        }
    }
}
