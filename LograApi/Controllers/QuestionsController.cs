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
    public class QuestionsController : ControllerBase
    {
        readonly IQuestionData Repo;
        public QuestionsController(IQuestionData repo)
        {
            Repo = repo;
        }
        // GET: api/<QuestionsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<QuestionsController>/5
        [HttpGet("{id}")]
        public async Task<IEnumerable<Question>> Get(Guid id)
        {
            return await Repo.GetQuestions(id);
        }

        // POST api/<QuestionsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<QuestionsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<QuestionsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
