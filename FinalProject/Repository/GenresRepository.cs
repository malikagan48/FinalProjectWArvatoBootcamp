using FinalProject.Interface;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
namespace FinalProject.Repository
{
    public class GenresRepository:IGenres
    {
        readonly ArvatoDbContext _dbContext = new();
        public GenresRepository(ArvatoDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Mytable> GetGenresDetails()
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
        public Mytable GetGenresDetails(string Genres)
        {
            try
            {
                Mytable? mytable = _dbContext.Mytables.Find(Genres);
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

        public void AddGenres(Mytable Genres)
        {
            try
            {
                _dbContext.Mytables.Add(Genres);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void UpdateGenres(Mytable Genres)
        {
            try
            {
                _dbContext.Entry(Genres).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public Mytable DeleteGenres(string Genres)
        {
            try
            {
                Mytable? mytable = _dbContext.Mytables.Find(Genres);

                if (mytable != null)
                {
                    _dbContext.Mytables.Remove(mytable);
                    _dbContext.SaveChanges();
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

        public bool CheckGenres(string Genres)
        {
            return _dbContext.Mytables.Any(e => e.Genres == Genres);
        }
    }
}
