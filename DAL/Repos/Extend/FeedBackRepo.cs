using DAL.Interfaces;
using DAL.Models.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Extend
{
    internal class FeedBackRepo : Repo, IRepo<FeedBack, int, bool>
    {
        public bool Create(FeedBack obj)
        {
            db.FeedBacks.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.FeedBacks.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<FeedBack> Read()
        {
            return db.FeedBacks.ToList();
        }

        public FeedBack Read(int id)
        {
            return db.FeedBacks.Find(id);
        }

        public bool Update(FeedBack obj)
        {
            var ex = Read(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
