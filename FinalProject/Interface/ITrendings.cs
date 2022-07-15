using FinalProject.Models;
namespace FinalProject.Interface
{
    public interface ITrendings
    {
        public List<Mytable> GetTrendingDetails();
        public Mytable GetTrendingDetails(string Popularity);
    }
}
