using LograData.Interfaces;
using LograModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LograData.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace LograData.Repository
{
    public class PruebaRepository : IPrueba
    {
        private readonly LograDbContext DB;
        public PruebaRepository(LograDbContext db)
        {
            DB = db;
        }

        public async Task<bool> getPrueba(string num)
        {
            try
            {
               
                await DB.pruebas.AddAsync(new Prueba() { Numero = num.ToString() });
                await DB.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
           

        }

        public IQueryable<Prueba> GetPruebas()
        {
            return DB.pruebas.AsQueryable();
           

        }

    
    }
}
