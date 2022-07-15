using FinalProject.Models;
namespace FinalProject.Interface
{
    public interface IMytable
    {
        public List<Mytable> GetMytableDetails();
        public Mytable GetMytableDetails(int id);
        public void AddMytable(Mytable mytable);
        public void UpdateMytable(Mytable mytable);
        public Mytable DeleteMytable(int id);
        public bool CheckMytable(int id);
    }
}
