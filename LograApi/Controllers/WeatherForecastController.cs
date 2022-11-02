using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LograData.Interfaces;
using LograData.Servicios;
using LograModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace LograApi.Controllers
{
    [ApiController]
    [Route("[controller]/[Action]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IPrueba Repo;

        public WeatherForecastController( IPrueba repo )
        {
           
            Repo = repo;
        }

        [HttpGet]
        public async Task<bool> Get()
        {
           return true;

        }

        [HttpGet("{s}")]
        public async Task<ActionResult<IEnumerable<Prueba>>> GetPruebas(int s)
        {
            var q = Repo.GetPruebas();
            await HttpContext.InsertarParametrosPaginacionEnRespuesta<Prueba>(q, 20);
            return await q.Paginar(new Paginacion() { Pagina = s, CantidadMostrar = 20 }).ToListAsync();

        }
    }
}
