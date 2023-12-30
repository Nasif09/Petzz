using DAL.Interfaces;
using DAL.Models.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Shop
{
    internal class Order_statusRepo : Repo, IRepo<Order_status, int, bool>
    {
        public bool Create(Order_status obj)
        {
            db.Orders_status.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Orders_status.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Order_status> Read()
        {
            return db.Orders_status.ToList();
        }

        public Order_status Read(int id)
        {
            return db.Orders_status.Find(id);
        }

        public bool Update(Order_status obj)
        {
            var ex = Read(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
