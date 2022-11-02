using LograModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LograData.Servicios
{
    public static class QueryableExtensions
    {
        public static IQueryable<T> Paginar<T>(this IQueryable<T> queryable, Paginacion paginacion)
        {
            return queryable
                .Skip((paginacion.Pagina - 1) * paginacion.CantidadMostrar)
                .Take(paginacion.CantidadMostrar);
        }
    }
}
