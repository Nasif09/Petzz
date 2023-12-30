using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class BranchRepo : Repo, IRepo<Branch, int, bool>
    {
        public bool Create(Branch obj)
        {
            db.Branchs.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Branchs.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Branch> Read()
        {
            return db.Branchs.ToList();
        }

        public Branch Read(int id)
        {
            return db.Branchs.Find(id);
        }

        public bool Update(Branch obj)
        {
            var ex = Read(obj.BranchID);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
