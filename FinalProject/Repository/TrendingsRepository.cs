using FinalProject.Entities;
using FinalProject.Interface;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
namespace FinalProject.Repository
{
    public class TrendingsRepository:ITrendings
    {
        readonly ArvatoDbContext _dbContext = new();
        public TrendingsRepository(ArvatoDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Mytable> ListMostViewedMovies()
        {
            List<Mytable> movie = _dbContext.Mytables.OrderByDescending(x => x.Popularity).Take(100).ToList();
            return movie;
        }

        public List<Mytable> ListTopRatedMovies()
        {
            List<Mytable> movie = _dbContext.Mytables.OrderByDescending(x => x.VoteAverage).Take(100).ToList();
            return movie;
        }

    }
}
