using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Logra.Services
{
    public class GetPost
    {
       
        public static async Task<T> Get<T>(string url)
        {
            bool Internet = await IsConnection.IsConnect();
            if (Internet)
            {
                var client = new HttpClient();
                var respo = await client.GetAsync(url);
                if (respo.StatusCode == System.Net.HttpStatusCode.OK)
                {

                    var jsonStr = await respo.Content.ReadAsStringAsync();
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(jsonStr);
                }
                return default(T);
            }
            return default;
           

        }


        public static async Task<T> Post<T>(string url, object obj)
        {
            bool Internet = await IsConnection.IsConnect();
            if (Internet)
            {
                var json = JsonConvert.SerializeObject(obj);
                HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

                var client = new HttpClient();

                var response = await client.PostAsync(url, content);
                if (response.StatusCode == System.Net.HttpStatusCode.OK) { }
                {
                    var jsonStr = await response.Content.ReadAsStringAsync();
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(jsonStr);
                }
                return default(T);
            }
            return default;

        }
    }
}
