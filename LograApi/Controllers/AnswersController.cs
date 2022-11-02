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
    public class AnswersController : ControllerBase
    {
        readonly IAnswerData Repo;
        public AnswersController(IAnswerData repo)
        {
            Repo = repo;
        }
        // GET: api/<AnswersController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AnswersController>/5
        [HttpGet("{id}")]
        public async Task<IEnumerable<Answer>> Get(Guid id)
        {
            return await Repo.GetAsnwers(id);
        }

        // POST api/<AnswersController>
        [HttpPost]
        public async Task<bool> Post(List<Answer> answers)
        {
            return await Repo.PostAnswers(answers);
        }

        // PUT api/<AnswersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AnswersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
