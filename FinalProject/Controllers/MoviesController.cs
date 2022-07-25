using Microsoft.AspNetCore.Http;
using FinalProject.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using FinalProject.Entities;

namespace FinalProject.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovies _IMytable;
        public MoviesController(IMovies IMytable)
        {
            _IMytable = IMytable;
        }
        [HttpGet("GetMovieDetail")] 
        [AllowAnonymous]
        public Mytable GetMovieDetail(long id)
        {
            return _IMytable.GetMovieDetail(id);
        }

        // GET api/<Movies>/5
        [HttpGet("GetMovieListGenre")]
        [AllowAnonymous]
        public List<Mytable> GetMovieList(int genreId)
        {
            return _IMytable.GetMovieList(genreId);
        }

        [HttpGet("GetMovieListRate")]
        [AllowAnonymous]
        public List<Mytable> GetMovieList(decimal rateFilter)
        {
            return _IMytable.GetMovieList(rateFilter);
        }

        [HttpGet("GetMovieListRelease")] 
        [AllowAnonymous]
        public List<Mytable> GetMovieList(string releaseDate)
        {
            return _IMytable.GetMovieList(releaseDate);
        }

        [HttpGet("Search")]
        [AllowAnonymous]
        public List<Mytable> Search(string title)
        {
            return _IMytable.Search(title);
        }

        // POST api/<Movies>
        [HttpPost]
        public void AddMovie([FromBody] Mytable mytable)
        {
            _IMytable.AddMovie(mytable);
        }

        // PUT api/<Movies>/5
        [HttpPut("{id}")]
        public void UpdateMovie(long id, [FromBody] Mytable mytable)
        {
            _IMytable.UpdateMovie(id, mytable);
        }

        // DELETE api/<Movies>/5
        [HttpDelete("{id}")]
        public void DeleteMovie(long id)
        {
            _IMytable.DeleteMovie(id);
        }
    }

}

