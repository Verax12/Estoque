using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Estoque.Aplicacao.DTO;
using Estoque.Aplicacao.Interfaces.Base;
using Estoque.Dominio.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Estoque.Services.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        readonly protected IAppBase<User, DTOUser> _IApp;

        public UsersController(IAppBase<User, DTOUser> IApp)
        {
            _IApp = IApp;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<DTOUser> Get()
        {
            IEnumerable<DTOUser> dTOUsers =_IApp.SelecionarTodos().ToList();

            return dTOUsers;
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
