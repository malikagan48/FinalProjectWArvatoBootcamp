using Microsoft.AspNetCore.Http;
using FinalProject.Models;
using FinalProject.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
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
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mytable>>> Get()
        {
            return await Task.FromResult(_ITrendings.GetTrendingDetails());
        }
        [HttpGet("{Trendings}")]
        public async Task<ActionResult<Mytable>> Get(string Popularity)
        {
            var mytable = await Task.FromResult(_ITrendings.GetTrendingDetails(Popularity));
            if (mytable == null)
            {
                return NotFound();
            }
            return mytable;
        }
    }
}
