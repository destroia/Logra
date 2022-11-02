using LograData.Interfaces;
using LograModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LograData.Repository
{
    public class LoginData : ILoginData
    {
        readonly LograDbContext DB;
        public LoginData(LograDbContext db)
        {
            DB = db;
        }
        public Admin LoginAdmin(Login login)
        {
            return DB.Admins.Where(x => x.Usuario == login.User && x.Password == login.Password).FirstOrDefault();
        }

        public User LoginUser(Login login)
        {   
           return DB.Users.Where(x => x.Codigo == login.Codigo).FirstOrDefault();
        }
    }
}
