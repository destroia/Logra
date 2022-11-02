using LograData.Interfaces;
using LograModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LograData.Repository
{
    public class UsersData : IUsersData
    {
        readonly LograDbContext DB;
        public UsersData(LograDbContext db)
        {
            DB = db;
        }
        public async Task<IEnumerable<User>> GetUsers(Guid garden )
        {
           
             return await DB.Users.Where(x => x.IdGarden == garden).ToListAsync();
            
        }

        public async Task<IEnumerable<User>> GetUsers(Guid garden, string emociones)
        {
            try
            {
                emociones = emociones.Substring(0, emociones.Length - 1);
                emociones = " desc";
                string consulta = "select * from Users where IdGarden = '" + garden + "' order by " + emociones;
                return await DB.Users.FromSqlRaw(consulta).ToListAsync();
            }
            catch (Exception)
            {

                return null;
            }
            
        }

        public async Task<bool> PostDeleteUser(User user)
        {
            try
            {

                //var Lanswer = await DB.Answers.FromSqlRaw(" delete FROM Answers Where IdUser = '" + user.Id + "'").ToListAsync();
                //DB.Answers.RemoveRange(Lanswer);
                //var LMoods = await DB.Moods.FromSqlRaw("delete FROM Moods Where IdUser = '" + user.Id + "'").ToListAsync();
                //DB.Moods.RemoveRange(LMoods);

                DB.Users.Remove(user);
                await DB.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
           
        }

        public async Task<User> PostInicioSesion(User user)
        {
            try
            {
                var res = await DB.Users.FromSqlRaw("select * from users where codigo = '" + user.Codigo + "' and " +
                    " Contraseña = '" + user.Contraseña + "'").FirstOrDefaultAsync();

                if (res == null)
                {
                    return new User() { Codigo = "0" };
                }
                return res;
            }
            catch (Exception)
            {

                return null;
            }
            
        }

        public async Task<User> PostUpdateRegistroUser(User user)
        {
            try
            {
                User usu = await DB.Users.FromSqlRaw("select * from users where codigo = '" + user.Codigo + "'").FirstOrDefaultAsync();
                if (usu == null)
                {
                    return new User() { Codigo = "0" };
                }
                usu.Email = user.Email;
                usu.UserName = user.UserName;
                usu.Contraseña = user.Contraseña;

                DB.Users.Update(usu);
                await DB.SaveChangesAsync();
                return usu;
            }
            catch (Exception)
            {

                return null;
            }
          


        }

        public async Task<bool> PostUpdateUser(User user)
        {
            try
            {   
                DB.Users.Update(user);
                await DB.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> PostUser(User user)
        {
            try
            {
                await DB.Users.AddAsync(user);
                await DB.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
