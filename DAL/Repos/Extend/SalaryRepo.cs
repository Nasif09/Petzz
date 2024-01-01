using DAL.Interfaces;
using DAL.Models.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Extend
{
    internal class SalaryRepo : Repo, IRepo<Salary, int, bool>
    {
        public bool Create(Salary obj)
        {
            db.Salarys.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Salarys.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Salary> Read()
        {
            return db.Salarys.ToList();
        }

        public Salary Read(int id)
        {
            return db.Salarys.Find(id);
        }

        public bool Update(Salary obj)
        {
            var ex = Read(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
