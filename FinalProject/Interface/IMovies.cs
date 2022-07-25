using FinalProject.Entities;

namespace FinalProject.Interface
{
    public interface IMovies
    {
        Mytable GetMovieDetail(long id);
        List<Mytable> GetMovieList(int genreId);
        List<Mytable> GetMovieList(decimal rateFilter);
        List<Mytable> GetMovieList(string releaseDate);
        List<Mytable> Search(string title);
        void AddMovie(Mytable movie);
        void UpdateMovie(long id, Mytable movie);
        void DeleteMovie(long id);
    }
}
