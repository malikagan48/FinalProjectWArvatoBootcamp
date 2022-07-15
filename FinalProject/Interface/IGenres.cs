using FinalProject.Models;
namespace FinalProject.Interface
{
    public interface IGenres
    {
        public List<Mytable> GetGenresDetails();
        public Mytable GetGenresDetails(string Genres);
        public void AddGenres(Mytable Genres);
        public void UpdateGenres(Mytable Genres);
        public Mytable DeleteGenres(string Genres);
        public bool CheckGenres(string Genres);
    }
}
