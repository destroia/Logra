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
    public class UsersController : ControllerBase
    {
        readonly IUsersData Repo;
        public UsersController(IUsersData repo)
        {
            Repo = repo;
        }
        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public async Task<IEnumerable<User>> Get(Guid id)
        {
            return await Repo.GetUsers(id);
        }
        [HttpGet]
        public async Task<IEnumerable<User>> Get(Guid id,string emocione)
        {
            return await Repo.GetUsers(id,emocione);
        }

        // POST api/<UsersController>
        [HttpPost]
        public async Task<bool> Post(User user)
        {
            return await Repo.PostUser(user);
        }

        // PUT api/<UsersController>/5
        [HttpPost]
        public async Task<bool> PostUpdate(User user)
        {
            return await Repo.PostUpdateUser(user);
        }
        [HttpPost]
        public async Task<User> PostUpdateRegistro(User user)
        {
            return await Repo.PostUpdateRegistroUser(user);
        }

        // DELETE api/<UsersController>/5
        [HttpPost]
        public async Task<bool> PostDelete(User user)
        {
            return await Repo.PostDeleteUser(user);
        }
        [HttpPost]
        public async Task<User> PostInicioSesion(User user)
        {
            return await Repo.PostInicioSesion(user);
        }
    }
}
