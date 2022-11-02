using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LograData.Interfaces;
using LograModel;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LograApi.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class GardensController : ControllerBase
    {
        readonly IGardenData Repo;
        public GardensController(IGardenData repo)
        {
            Repo = repo;
        }
        // GET: api/<GardensController>
        [HttpGet("{id}")]
        public async Task<IEnumerable<Garden>> Get(Guid id)
        {
            return await Repo.GetGardens(id);
        }

        // GET api/<GardensController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<GardensController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<GardensController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GardensController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
