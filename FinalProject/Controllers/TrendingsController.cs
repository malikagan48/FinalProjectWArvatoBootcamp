using FinalProject.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FinalProject.Entities;

namespace FinalProject.Controllers
{
    [Authorize]
    [Route("api/controller")]
    [ApiController]
    public class TrendingsController : ControllerBase
    {
        private readonly ITrendings _ITrendings;
        public TrendingsController(ITrendings ITrendings)
        {
            _ITrendings = ITrendings;
        }
        [HttpGet("ListMostViewedMovies")]
        public List<Mytable> ListMostViewedMovies() 
        {
            return _ITrendings.ListMostViewedMovies();
        }

        // GET api/<TrendingController>
        [HttpGet("ListTopRatedMovies")]
        public List<Mytable> ListTopRatedMovies()
        {
            return _ITrendings.ListTopRatedMovies();
        }
    }
}
