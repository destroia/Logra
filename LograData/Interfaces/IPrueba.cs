using LograModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LograData.Interfaces
{
    public interface IPrueba
    {
        Task<bool> getPrueba(string num);
        IQueryable<Prueba> GetPruebas();
    }
}
