using LograModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Logra.Services
{
    public class UserService
    {
        public static async Task<User> PostUpdateRegistroUser(User user)
        {
            return await GetPost.Post<User>(Url.url + "api/Users/PostUpdateRegistro", user);
        }
        public static async Task<User> PostInicioSesion(User user)
        {
            return await GetPost.Post<User>(Url.url + "api/Users/PostInicioSesion", user);
        }
    }
}
