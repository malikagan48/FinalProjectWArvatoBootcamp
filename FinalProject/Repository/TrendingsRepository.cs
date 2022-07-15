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
        public List<Mytable> GetTrendingDetails()
        {
            try
            {
                return _dbContext.Mytables.ToList();
            }
            catch
            {
                throw;
            }
        }
        public Mytable GetTrendingDetails(string Popularity)
        {
            try
            {
                Mytable? mytable = _dbContext.Mytables.Find(Popularity);
                if (mytable != null)
                {
                    return mytable;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }

    }
}
