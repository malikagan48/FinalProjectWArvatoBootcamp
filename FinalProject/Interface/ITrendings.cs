using FinalProject.Entities;

namespace FinalProject.Interface
{
    public interface ITrendings
    {
        List<Mytable> ListMostViewedMovies();
        List<Mytable> ListTopRatedMovies();
    }
}
