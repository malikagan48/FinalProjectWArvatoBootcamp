using Microsoft.AspNetCore.Http;
using FinalProject.Models;
using FinalProject.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class GenresControllers : ControllerBase
    {
        private readonly IGenres _IGenres;
        public GenresControllers(IGenres IGenres)
        {
            _IGenres = IGenres;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mytable>>> Get()
        {
            return await Task.FromResult(_IGenres.GetGenresDetails());
        }
        [HttpGet("{Genres}")]
        public async Task<ActionResult<Mytable>> Get(string Genres)
        {
            var mytable = await Task.FromResult(_IGenres.GetGenresDetails(Genres));
            if (mytable == null)
            {
                return NotFound();
            }
            return mytable;
        }

        [HttpPost]
        public async Task<ActionResult<Mytable>> Post(Mytable mytable)
        {
            _IGenres.AddGenres(mytable);
            return await Task.FromResult(mytable);
        }

        // PUT api/employee/5
        [HttpPut("{Genres}")]
        public async Task<ActionResult<Mytable>> Put(string Genres, Mytable mytable)
        {
            if (Genres != mytable.Genres)
            {
                return BadRequest();
            }
            try
            {
                _IGenres.UpdateGenres(mytable);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeExists(Genres))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return await Task.FromResult(mytable);
        }

        // DELETE api/employee/5
        [HttpDelete("{Genres}")]
        public async Task<ActionResult<Mytable>> Delete(string Genres)
        {
            var mytable = _IGenres.DeleteGenres(Genres);
            return await Task.FromResult(mytable);
        }
        [HttpHead]
        private bool EmployeeExists(string Genres)
        {
            return _IGenres.CheckGenres(Genres);
        }

    }
}
