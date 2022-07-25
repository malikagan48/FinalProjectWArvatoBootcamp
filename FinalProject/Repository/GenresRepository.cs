using FinalProject.Entities;
using FinalProject.Interface;
using FinalProject.Models;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
namespace FinalProject.Repository
{
    public class GenresRepository : IGenres
    {
        readonly ArvatoDbContext _dbContext = new();
        public GenresRepository(ArvatoDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddGenre(long movieId, Genres genre) //Add genre için gerekli olan parametreler
        {

            var mytable = _dbContext.Mytables.Where(x => x.Id == movieId).FirstOrDefault();
            if (mytable != null)
            {
                List<Genres> genres = new List<Genres>();
                if (string.IsNullOrWhiteSpace(mytable.Genres))
                {
                    genres.Add(genre);
                    var genreSerialize = JsonConvert.SerializeObject(genres);//mevcut json formatlı genres datasına sahip olduğumuz için Serilize işlemine ihtiyaç duyuyoruz.
                    mytable.Genres = genreSerialize;
                }
                else
                {
                    var temp = JsonConvert.DeserializeObject<List<Genres>>(mytable.Genres);
                    if (temp != null)
                    {
                        temp.Add(genre);
                        genres = temp;
                    }
                    var genreSerialize = JsonConvert.SerializeObject(genres);
                    mytable.Genres = genreSerialize;

                }

                _dbContext.Update(mytable);
                _dbContext.SaveChanges();
            }
        }

        public void DeleteByMovieAllGenre(long movieId)
        {
            var mytable = _dbContext.Mytables.Where(x => x.Id == movieId).FirstOrDefault();
            if (mytable != null)
            {
                List<Genres> genres = new List<Genres>();

                var temp = JsonConvert.DeserializeObject<List<Genres>>(mytable.Genres);
                if (temp != null && temp.Count > 0)
                {
                    temp.Clear();
                    genres = temp;
                }
                var genreSerialize = JsonConvert.SerializeObject(genres);
                mytable.Genres = genreSerialize;

                _dbContext.Update(mytable);
                _dbContext.SaveChanges();
            }
        }

        public void DeleteGenre(long movieId, int genreId)
        {
            var mytable = _dbContext.Mytables.Where(x => x.Id == movieId).FirstOrDefault();
            if (mytable != null)
            {
                List<Genres> genres = new List<Genres>();

                var temp = JsonConvert.DeserializeObject<List<Genres>>(mytable.Genres);
                if (temp != null && temp.Count > 0)
                {
                    var tempGenre = temp.Find(x => x.Id == genreId);
                    if (tempGenre != null)
                    {
                        temp.Remove(tempGenre);
                    }
                    genres = temp;
                }
                var genreSerialize = JsonConvert.SerializeObject(genres);
                mytable.Genres = genreSerialize;

                _dbContext.Update(mytable);
                _dbContext.SaveChanges();
            }
        }
        public List<Genres> ListGenres(long movieId)
        {
            var mytable = _dbContext.Mytables.Where(x => x.Id == movieId).FirstOrDefault();
            if (mytable != null && !string.IsNullOrWhiteSpace(mytable.Genres))
            {
                var genres = JsonConvert.DeserializeObject<List<Genres>>(mytable.Genres);
                if (genres != null) return genres;
                return new List<Genres>();
            }
            else
            {
                return new List<Genres>();
            }
        }

        public void UpdateGenre(long movieId, int genreId, Genres genre)
        {
            var mytable = _dbContext.Mytables.Where(x => x.Id == movieId).FirstOrDefault();
            if (mytable != null)
            {
                List<Genres> genres = new List<Genres>();

                var temp = JsonConvert.DeserializeObject<List<Genres>>(mytable.Genres);
                if (temp != null && temp.Count > 0)
                {
                    var tempGenre = temp.Find(x => x.Id == genreId);
                    if (tempGenre != null)
                    {
                        tempGenre.Name = genre.Name;
                        int index = temp.IndexOf(tempGenre);
                        if (index > -1) temp[index] = genre;
                    }
                    genres = temp;
                }
                var genreSerialize = JsonConvert.SerializeObject(genres);
                mytable.Genres = genreSerialize;

                _dbContext.Update(mytable);
                _dbContext.SaveChanges();
            }
        }
    }
}
