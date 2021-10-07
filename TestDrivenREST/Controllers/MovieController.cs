using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using ModelLib.Model;
using TestDrivenREST.Managers;

namespace TestDrivenREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : Controller
    {
        private IManageFilm mgr = new ManageFilms();

        [HttpGet]
        public IEnumerable<Film> Get()
        {
            return mgr.Get();
        }

        [HttpGet]
        public Film GetProgram(string title)
        {
            return mgr.GetProgram(title);
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(mgr.Get(id));
            }
            catch (KeyNotFoundException knfe)
            {
                return NotFound(knfe.Message);
            }

        }

        [HttpPost]
        public bool Post([FromBody] Film value)
        {
            return mgr.Create(value);
        }

        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] Film value)
        {
            return mgr.Update(id, value);
        }

        [HttpDelete("{id}")]
        public Film Delete(int id)
        {
            return mgr.Delete(id);
        }
    }
}
