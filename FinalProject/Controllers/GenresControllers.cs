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
    public class GenresControllers : ControllerBase
    {
        private readonly IGenres _IGenres;
        public GenresControllers(IGenres IGenres)
        {
            _IGenres = IGenres;
        }
        [HttpGet]
        [AllowAnonymous]
        public List<Genres> ListGenres(long movieId)
        {
            return _IGenres.ListGenres(movieId);
        }
        [HttpPost]
        public void AddGenre(long movieId, [FromBody] Genres genre) 
        {
            _IGenres.AddGenre(movieId, genre);

        }

        // PUT api/<GenresController>/5
        [HttpPut("{movieId}")]
        public void UpdateGenre(long movieId, int genreId, [FromBody] Genres genre) 
        {
            _IGenres.UpdateGenre(movieId, genreId, genre);

        }

        // DELETE api/<GenresController>/5
        [HttpDelete("{movieId}")] 
        public void DeleteGenre(long movieId, int genreId)
        {
            _IGenres.DeleteGenre(movieId, genreId);
        }
    }
}
