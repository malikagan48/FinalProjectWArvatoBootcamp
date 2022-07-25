using FinalProject.Entities;

namespace FinalProject.Interface
{
    public interface IGenres
    {
        List<Genres> ListGenres(long movieId);
        void AddGenre(long movieId, Genres genre);
        void UpdateGenre(long movieId, int genreId, Genres genre);
        void DeleteGenre(long movieId, int genreId);
        void DeleteByMovieAllGenre(long movieId);
    }
}
