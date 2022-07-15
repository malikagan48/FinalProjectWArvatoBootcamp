using FinalProject.Interface;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Repository
{
    public class MytableRepository:IMytable
    {
        readonly ArvatoDbContext _dbContext = new();
        public MytableRepository(ArvatoDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Mytable> GetMytableDetails()
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
        public Mytable GetMytableDetails(int id)
        {
            try
            {
                Mytable? mytable = _dbContext.Mytables.Find(id);
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

        public void AddMytable(Mytable mytable)
        {
            try
            {
                _dbContext.Mytables.Add(mytable);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void UpdateMytable(Mytable mytable)
        {
            try
            {
                _dbContext.Entry(mytable).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public Mytable DeleteMytable(int id)
        {
            try
            {
                Mytable? mytable = _dbContext.Mytables.Find(id);

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

        public bool CheckMytable(int id)
        {
            return _dbContext.Mytables.Any(e => e.Id == id);
        }
    }
}

