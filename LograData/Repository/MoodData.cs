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
    public class MoodData : IMoodData
    {
        readonly LograDbContext DB;
        public MoodData(LograDbContext db)
        {
            DB = db;
        }

        public async Task<IEnumerable<Mood>> GetMoods(Guid idUsers, string tiempo)
        {
            DateTime fecha;
            switch (tiempo)
            {
                case "semana":
                    fecha = DateTime.Now.AddDays(-7);
                    break;
                case "dos semanas":
                    fecha = DateTime.Now.AddDays(-14);
                    break;
                case "mes":
                    fecha = DateTime.Now.AddDays(30);
                    break;
                case "historial":
                    fecha= DateTime.Now.AddDays(-3000);
                    break;
                default : 
                    fecha = DateTime.Now.AddDays(-3000);
                    break;
            }
            return await DB.Moods.Where(x => x.Id == idUsers && x.Fecha >= fecha).ToListAsync();
        }

        public async Task<bool> PostMood(Mood mood)
        {
            try
            {
                var usu = await DB.Users.FindAsync(mood.IdUser);

                if (mood.Emocion == "Felicidad")
                {
                    // DB.Users.FromSqlRaw("update Users set Emocion1 = Emocion1 + 1 where id = '" + mood.IdUser + "'");
                    usu.Emocion1 += 1;
                    
                }
                else if (mood.Emocion == "mal humor")
                {
                    //DB.Users.FromSqlRaw("update Users set Emocion2 = Emocion2 + 1 where id = '" + mood.IdUser + "'");
                    usu.Emocion2 += 1;
                }
                else if (mood.Emocion ==  "triste")
                {
                    //DB.Users.FromSqlRaw("update Users set Emocion3 = Emocion3 + 1 where id = '" + mood.IdUser + "'");
                    usu.Emocion3 += 1;
                }
                else if (mood.Emocion == "estres")
                {
                    // DB.Users.FromSqlRaw("update Users set Emocion4 = Emocion4 + 1 where id = '" + mood.IdUser + "'");
                    usu.Emocion4 += 1;
                }
                else if (mood.Emocion ==  "matoneo")
                {
                   // DB.Users.FromSqlRaw("update Users set Emocion5 = Emocion5 + 1 where id = '" + mood.IdUser + "'");
                    usu.Emocion5 += 1;
                }
                mood.Fecha = DateTime.Now;
                //TODO aumentar detonantes para usuario  
                await DB.Moods.AddAsync(mood);
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
