using FinalProject.Entities;
using FinalProject.Interface;
using Newtonsoft.Json;
using FinalProject.Models;

namespace FinalProject.Repository
{
    public class MoviesRepository:IMovies
    {
        readonly ArvatoDbContext _dbContext = new();
        public MoviesRepository(ArvatoDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddMovie(Mytable movie)
        {
            Genres genre = new Genres();
            List<Genres> genres = new List<Genres>();
            if (string.IsNullOrWhiteSpace(movie.Genres))
            {
                movie.Genres = "[]"; 
            }
            if (string.IsNullOrWhiteSpace(movie.SpokenLanguages))
            {
                movie.SpokenLanguages = "[]";
            }
            if (string.IsNullOrWhiteSpace(movie.ProductionCompanies))
            {
                movie.ProductionCompanies = "[]";
            }
            if (string.IsNullOrWhiteSpace(movie.ProductionCompanies))
            {
                movie.ProductionCompanies = "[]";
            }

            _dbContext.Add(movie);
            _dbContext.SaveChanges();
        }

        public void DeleteMovie(long id)
        {
            var movie = _dbContext.Mytables.Where(x => x.Id == id).FirstOrDefault();
            if (movie != null)
            {
                _dbContext.Remove(movie);
                _dbContext.SaveChanges();
            }
        }

        public Mytable GetMovieDetail(long id)
        {
#pragma warning disable CS8600 // Null sabit değeri veya olası null değeri, boş değer atanamaz türe dönüştürülüyor.
            Mytable movie = _dbContext.Mytables.Where(x => x.Id == id).FirstOrDefault();
#pragma warning restore CS8600 // Null sabit değeri veya olası null değeri, boş değer atanamaz türe dönüştürülüyor.
            return movie;
        }

        public List<Mytable> GetMovieList(int genreId)
        {
            List<Mytable> movie = _dbContext.Mytables.ToList();
            movie = movie.Where(x => x.Genres.IndexOf($"'id'={genreId}", StringComparison.InvariantCultureIgnoreCase) > -1).ToList();
            return movie;
        }

        public List<Mytable> GetMovieList(decimal rateFilter)
        {
            List<Mytable> movie = _dbContext.Mytables.ToList();
            movie = movie.Where(x => x.VoteAverage >= rateFilter).ToList();
            return movie;
        }

        public List<Mytable> GetMovieList(string releaseDate)
        {
            List<Mytable> movie = _dbContext.Mytables
                .ToList();
            movie = movie.Where(x => (!string.IsNullOrWhiteSpace(x.ReleaseDate)
             && x.ReleaseDate.Equals(releaseDate, StringComparison.InvariantCultureIgnoreCase)))
                .ToList();
            return movie;
        }

        public List<Mytable> Search(string title)
        {
            List<Mytable> movies = _dbContext.Mytables.ToList();
            movies = movies.Where(x => (!string.IsNullOrWhiteSpace(x.Title) &&
            x.Title.IndexOf($"{title}", StringComparison.InvariantCultureIgnoreCase) > -1)).ToList();
            return movies;
        }

        public void UpdateMovie(long id, Mytable movie)
        {
            var mytable = _dbContext.Mytables.Where(x => x.Id == id).FirstOrDefault();
            if (mytable == null) return;
            Genres genre = new Genres();
            List<Genres> genres = new List<Genres>();
            if (string.IsNullOrWhiteSpace(movie.Genres))
            {
                movie.Genres = "[]";
            }
            if (string.IsNullOrWhiteSpace(movie.SpokenLanguages))
            {
                movie.SpokenLanguages = "[]";
            }
            if (string.IsNullOrWhiteSpace(movie.ProductionCompanies))
            {
                movie.ProductionCompanies = "[]";
            }
            if (string.IsNullOrWhiteSpace(movie.ProductionCompanies))
            {
                movie.ProductionCompanies = "[]";
            }

            _dbContext.Update(movie);
            _dbContext.SaveChanges();
        }
    }
}

